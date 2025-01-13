using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using kutuphane.models;

namespace kutuphane.Controllers
{
    public class OduncController
    {
        private readonly string _connectionString = "Data Source=TALHAY\\SQLEXPRESS03;Initial Catalog=KutuphaneDB;Integrated Security=True;";

        public List<OduncModel> OduncKitaplariGetir(int kullaniciID)
        {
            var oduncKitaplar = new List<OduncModel>();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    // Kitaplar tablosundan KitapAdi'ni de almak için JOIN ekledik
                    string query = @"
                SELECT 
                    o.KullaniciID, 
                    o.KitapID, 
                    k.KitapAdi, 
                    o.OduncTarihi, 
                    o.IadeTarihi, 
                    o.GecikmeCezasi 
                FROM OduncKitaplar o
                INNER JOIN Kitaplar k ON o.KitapID = k.KitapID
                WHERE o.KullaniciID = @KullaniciID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        oduncKitaplar.Add(new OduncModel
                        {
                            KullaniciID = reader.GetInt32(0),
                            KitapID = reader.GetInt32(1),
                            KitapAdi = reader.GetString(2), // KitapAdi'ni alıyoruz
                            OduncTarihi = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3), // NULL kontrolü
                            IadeTarihi = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4), // NULL kontrolü
                            GecikmeCezasi = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5) // NULL kontrolü
                        });
                    }
                }
            }
            catch (SqlException ex)
            {
                // Veritabanı ile ilgili hataları ele al
                Console.WriteLine("Veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Diğer tüm hataları ele al
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }
            return oduncKitaplar;
        }



        public bool OduncVer(int kullaniciID, int kitapID)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Update stock
                        string stockQuery = "UPDATE Kitaplar SET StokSayisi = StokSayisi - 1 WHERE KitapID = @KitapID AND StokSayisi > 0";
                        SqlCommand stockCmd = new SqlCommand(stockQuery, conn, transaction);
                        stockCmd.Parameters.AddWithValue("@KitapID", kitapID);

                        if (stockCmd.ExecuteNonQuery() == 0)
                            throw new Exception("Kitap stokta yok!");

                        // Insert odunc
                        string oduncQuery = "INSERT INTO OduncKitaplar (KitapID, KullaniciID, OduncTarihi, IadeTarihi) VALUES (@KitapID, @KullaniciID, @OduncTarihi, @IadeTarihi)";
                        SqlCommand oduncCmd = new SqlCommand(oduncQuery, conn, transaction);
                        oduncCmd.Parameters.AddWithValue("@KitapID", kitapID);
                        oduncCmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                        oduncCmd.Parameters.AddWithValue("@OduncTarihi", DateTime.Now);
                        oduncCmd.Parameters.AddWithValue("@IadeTarihi", DateTime.Now.AddDays(14));

                        oduncCmd.ExecuteNonQuery();

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public bool IadeAl(int kullaniciID, int kitapID)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Delete odunc
                        string deleteQuery = "DELETE FROM OduncKitaplar WHERE KitapID = @KitapID AND KullaniciID = @KullaniciID";
                        SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn, transaction);
                        deleteCmd.Parameters.AddWithValue("@KitapID", kitapID);
                        deleteCmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);

                        if (deleteCmd.ExecuteNonQuery() == 0)
                            throw new Exception("Kitap zaten iade edilmiş veya bulunamadı!");

                        // Update stock
                        string stockQuery = "UPDATE Kitaplar SET StokSayisi = StokSayisi + 1 WHERE KitapID = @KitapID";
                        SqlCommand stockCmd = new SqlCommand(stockQuery, conn, transaction);
                        stockCmd.Parameters.AddWithValue("@KitapID", kitapID);

                        stockCmd.ExecuteNonQuery();

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
    }
}