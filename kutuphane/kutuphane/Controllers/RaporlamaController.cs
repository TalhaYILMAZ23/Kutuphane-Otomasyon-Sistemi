using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using kutuphane.models;

namespace kutuphane.Controllers
{
    public class RaporlamaController
    {
        private readonly string _connectionString = "Data Source=TALHAY\\SQLEXPRESS03;Initial Catalog=KutuphaneDB;Integrated Security=True;";

        public List<RaporModel> PopulerKitaplar()
        {
            var kitaplar = new List<RaporModel>();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "SELECT k.KitapAdi, COUNT(o.OduncID) AS OduncSayisi " +
                                   "FROM OduncKitaplar o JOIN Kitaplar k ON o.KitapID = k.KitapID " +
                                   "GROUP BY k.KitapAdi ORDER BY OduncSayisi DESC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        kitaplar.Add(new RaporModel
                        {
                            KitapAdi = reader.GetString(0),
                            OduncSayisi = reader.GetInt32(1)
                        });
                    }
                }
            }
            catch (SqlException ex)
            {
                // Veritabanı hatalarını yakala
                Console.WriteLine("Veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Diğer hataları yakala
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }
            return kitaplar;

        }

        public List<RaporModel> AktifUyeler()
        {
            var uyeler = new List<RaporModel>();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "SELECT u.Ad + ' ' + u.Soyad AS EnAktifUye, COUNT(o.OduncID) AS UyeOduncSayisi " +
                                   "FROM OduncKitaplar o JOIN Kullanicilar u ON o.KullaniciID = u.KullaniciID " +
                                   "GROUP BY u.Ad, u.Soyad ORDER BY UyeOduncSayisi DESC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        uyeler.Add(new RaporModel
                        {
                            EnAktifUye = reader.GetString(0),
                            UyeOduncSayisi = reader.GetInt32(1)
                        });
                    }
                }
            }
            catch (SqlException ex)
            {
                // Veritabanı hatalarını yakala
                Console.WriteLine("Veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Diğer hataları yakala
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }
            return uyeler;

        }

        public void ExportToPdf(List<RaporModel> data, string fileName, string title)
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, fileName);

                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                // Başlık
                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                document.Add(new Paragraph(title, titleFont));
                document.Add(new Paragraph("\n"));

                // Tablo
                PdfPTable table = new PdfPTable(2);
                table.AddCell("Adi");
                table.AddCell("Odunc Sayisi");

                foreach (var item in data)
                {
                    table.AddCell(item.KitapAdi ?? item.EnAktifUye);
                    table.AddCell((item.OduncSayisi > 0 ? item.OduncSayisi : item.UyeOduncSayisi).ToString());
                }

                document.Add(table);
                document.Close();

                Console.WriteLine("PDF başarıyla oluşturuldu: " + filePath);
            }
            catch (IOException ex)
            {
                // Dosya ile ilgili bir hata oluştuğunda burası çalışır
                Console.WriteLine("Dosya yazma hatası: " + ex.Message);
            }
            catch (DocumentException ex)
            {
                // PDF oluşturma ile ilgili bir hata oluştuğunda burası çalışır
                Console.WriteLine("PDF oluşturma hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Diğer tüm hatalar için burası çalışır
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }

        }
        public List<RaporModel> TumKitaplariGetir()
        {
            var kitaplar = new List<RaporModel>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT KitapAdi, StokSayisi FROM Kitaplar";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kitaplar.Add(new RaporModel
                            {
                                KitapAdi = reader["KitapAdi"].ToString(),
                                StokSayisi = Convert.ToInt32(reader["StokSayisi"])
                            });
                        }
                    }
                }
            }

            return kitaplar;
        }
        public List<RaporModel> KritikKitaplariGetir()
        {
            var kritikKitaplar = new List<RaporModel>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT KitapAdi, StokSayisi FROM Kitaplar WHERE StokSayisi < 10";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kritikKitaplar.Add(new RaporModel
                            {
                                KitapAdi = reader["KitapAdi"].ToString(),
                                StokSayisi = Convert.ToInt32(reader["StokSayisi"])
                            });
                        }
                    }
                }
            }

            return kritikKitaplar;
        }
    }
}
