using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kutuphane.Controllers
{
    public class LoginController
    {
        // Kullanıcı adı ve şifre ile doğrulama işlemi
        public static bool KullaniciGirisYap(string kullaniciAdi, string sifre, out string rol)
        {
            rol = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=TALHAY\\SQLEXPRESS03;Initial Catalog=KutuphaneDB;Integrated Security=True;"))
                {
                    string query = "SELECT Rol FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@Sifre", sifre);

                    conn.Open();
                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        rol = result.ToString(); // Kullanıcının rolünü al
                        return true; // Başarılı giriş
                    }
                    return false; // Hatalı kullanıcı adı veya şifre
                }
            }
            catch (SqlException ex)
            {
                // Veritabanı hatalarını yakala
                Console.WriteLine("Veritabanı hatası: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                // Genel hataları yakala
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
                return false;
            }

        }
    }
}
