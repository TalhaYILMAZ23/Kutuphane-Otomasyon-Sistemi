using kutuphane.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace kutuphane.Controllers
{
    public class KitapController
    {
        private readonly string _connectionString = "Data Source=TALHAY\\SQLEXPRESS03;Initial Catalog=KutuphaneDB;Integrated Security=True;";

        public List<KitapModel> KitaplariGetir()
        {
            try
            {
                var kitaplar = new List<KitapModel>();
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "SELECT KitapID, KitapAdi, YazarAdi, Kategori, StokSayisi FROM Kitaplar";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        kitaplar.Add(new KitapModel
                        {
                            KitapID = reader.GetInt32(0),
                            KitapAdi = reader.GetString(1),
                            YazarAdi = reader.GetString(2),
                            Kategori = reader.GetString(3),
                            StokSayisi = reader.GetInt32(4)
                        });
                    }
                }
                return kitaplar;
            }
            catch (SqlException sqlEx)
            {
                // SQL hatası ile ilgili işlem yapabilirsiniz.
                Console.WriteLine($"SQL hata mesajı: {sqlEx.Message}");
                return new List<KitapModel>(); // Hata durumunda boş liste döndürülüyor
            }
            catch (Exception ex)
            {
                // Diğer hatalar için işlem yapabilirsiniz.
                Console.WriteLine($"Hata mesajı: {ex.Message}");
                return new List<KitapModel>(); // Hata durumunda boş liste döndürülüyor
            }

        }

        public bool KitapEkle(KitapModel kitap)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "INSERT INTO Kitaplar (KitapAdi, YazarAdi, Kategori, StokSayisi) VALUES (@KitapAdi, @YazarAdi, @Kategori, @StokSayisi)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@KitapAdi", kitap.KitapAdi);
                    cmd.Parameters.AddWithValue("@YazarAdi", kitap.YazarAdi);
                    cmd.Parameters.AddWithValue("@Kategori", kitap.Kategori);
                    cmd.Parameters.AddWithValue("@StokSayisi", kitap.StokSayisi);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                // SQL hatası ile ilgili işlem yapabilirsiniz.
                Console.WriteLine($"SQL hata mesajı: {sqlEx.Message}");
                return false; // Hata durumunda false döndürülüyor
            }
            catch (Exception ex)
            {
                // Diğer hatalar için işlem yapabilirsiniz.
                Console.WriteLine($"Hata mesajı: {ex.Message}");
                return false; // Hata durumunda false döndürülüyor
            }

        }

        public bool KitapGuncelle(KitapModel kitap)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "UPDATE Kitaplar SET KitapAdi = @KitapAdi, YazarAdi = @YazarAdi, Kategori = @Kategori, StokSayisi = @StokSayisi WHERE KitapID = @KitapID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@KitapID", kitap.KitapID);
                    cmd.Parameters.AddWithValue("@KitapAdi", kitap.KitapAdi);
                    cmd.Parameters.AddWithValue("@YazarAdi", kitap.YazarAdi);
                    cmd.Parameters.AddWithValue("@Kategori", kitap.Kategori);
                    cmd.Parameters.AddWithValue("@StokSayisi", kitap.StokSayisi);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                // SQL hatası ile ilgili işlem yapabilirsiniz.
                Console.WriteLine($"SQL hata mesajı: {sqlEx.Message}");
                return false; // Hata durumunda false döndürülüyor
            }
            catch (Exception ex)
            {
                // Diğer hatalar için işlem yapabilirsiniz.
                Console.WriteLine($"Hata mesajı: {ex.Message}");
                return false; // Hata durumunda false döndürülüyor
            }

        }

        public bool KitapSil(int kitapID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "DELETE FROM Kitaplar WHERE KitapID = @KitapID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@KitapID", kitapID);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                // SQL hatası ile ilgili işlem yapabilirsiniz.
                Console.WriteLine($"SQL hata mesajı: {sqlEx.Message}");
                return false; // Hata durumunda false döndürülüyor
            }
            catch (Exception ex)
            {
                // Diğer hatalar için işlem yapabilirsiniz.
                Console.WriteLine($"Hata mesajı: {ex.Message}");
                return false; // Hata durumunda false döndürülüyor
            }

        }
    }
}