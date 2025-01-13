using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using kutuphane.models;

namespace kutuphane.Controllers
{
    public class UyeYonetimController
    {
        private readonly string _connectionString = "Data Source=TALHAY\\SQLEXPRESS03;Initial Catalog=KutuphaneDB;Integrated Security=True;";

        public List<UyeYonetimModel> UyeListele()
        {
            var uyeListesi = new List<UyeYonetimModel>();

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "SELECT KullaniciID, Ad, Soyad, Email, Telefon, Sifre, Rol FROM Kullanicilar";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        uyeListesi.Add(new UyeYonetimModel
                        {
                            KullaniciID = reader.GetInt32(0),
                            Ad = reader.GetString(1),
                            Soyad = reader.GetString(2),
                            Email = reader.GetString(3),
                            Telefon = reader.GetString(4),
                            Sifre = reader.GetString(5),
                            Rol = reader.GetString(6)
                        });
                    }
                }
            }
            catch (SqlException ex)
            {
                // Veritabanı ile ilgili hataları yakala
                Console.WriteLine("Veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Diğer beklenmeyen hataları yakala
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }

            return uyeListesi;

        }

        public void UyeEkle(UyeYonetimModel yeniUye)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "INSERT INTO Kullanicilar (Ad, Soyad, Email, Telefon, Sifre, Rol) VALUES (@Ad, @Soyad, @Email, @Telefon, @Sifre, @Rol)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ad", yeniUye.Ad);
                    cmd.Parameters.AddWithValue("@Soyad", yeniUye.Soyad);
                    cmd.Parameters.AddWithValue("@Email", yeniUye.Email);
                    cmd.Parameters.AddWithValue("@Telefon", yeniUye.Telefon);
                    cmd.Parameters.AddWithValue("@Sifre", yeniUye.Sifre);
                    cmd.Parameters.AddWithValue("@Rol", "Üye");

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Kullanıcı başarıyla eklendi.");
                }
            }
            catch (SqlException ex)
            {
                // Veritabanı hatalarını yakala
                Console.WriteLine("Veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Diğer beklenmedik hataları yakala
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }

        }

        public void UyeGuncelle(UyeYonetimModel guncelUye)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "UPDATE Kullanicilar SET Ad = @Ad, Soyad = @Soyad, Email = @Email, Telefon = @Telefon, Sifre = @Sifre WHERE KullaniciID = @KullaniciID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ad", guncelUye.Ad);
                    cmd.Parameters.AddWithValue("@Soyad", guncelUye.Soyad);
                    cmd.Parameters.AddWithValue("@Email", guncelUye.Email);
                    cmd.Parameters.AddWithValue("@Telefon", guncelUye.Telefon);
                    cmd.Parameters.AddWithValue("@Sifre", guncelUye.Sifre);
                    cmd.Parameters.AddWithValue("@KullaniciID", guncelUye.KullaniciID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                // SQL hatası ile ilgili işlem yapabilirsiniz.
                Console.WriteLine($"SQL hata mesajı: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                // Diğer hatalar için işlem yapabilirsiniz.
                Console.WriteLine($"Hata mesajı: {ex.Message}");
            }

        }

        public void UyeSil(int kullaniciID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "DELETE FROM Kullanicilar WHERE KullaniciID = @KullaniciID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                // SQL hatası ile ilgili işlem yapabilirsiniz.
                Console.WriteLine($"SQL hata mesajı: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                // Diğer hatalar için işlem yapabilirsiniz.
                Console.WriteLine($"Hata mesajı: {ex.Message}");
            }

        }
    }
}