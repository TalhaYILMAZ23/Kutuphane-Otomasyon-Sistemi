using kutuphane;
using kutuphane.forms;
using Kutuphane;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kutuphane
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }




        // Kullanıcı adı, soyadı ve şifreyi veritabanında kontrol et
        private bool KullaniciGirisYap(string ad, string soyad, string sifre, out string rol, out int kullaniciID)
        {
            rol = string.Empty;
            kullaniciID = 0;

            using (SqlConnection conn = new SqlConnection("Data Source=TALHAY\\SQLEXPRESS03;Initial Catalog=KutuphaneDB;Integrated Security=True;"))
            {
                string query = "SELECT KullaniciID, Rol FROM Kullanicilar WHERE Ad = @Ad AND Soyad = @Soyad AND Sifre = @Sifre";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ad", ad);
                cmd.Parameters.AddWithValue("@Soyad", soyad);
                cmd.Parameters.AddWithValue("@Sifre", sifre);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        kullaniciID = (int)reader["KullaniciID"]; // Kullanıcı ID'sini al
                        rol = reader["Rol"].ToString(); // Kullanıcının rolünü al
                        return true; // Giriş başarılı
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantısı hatası: " + ex.Message);
                }
                return false; // Ad, Soyad veya Şifre hatalı
            }
        }
        private void kayitOl_btn_Click_1(object sender, EventArgs e)
        {
            KayitOlForm kayitForm = new KayitOlForm();
            kayitForm.Show();
        }

        private void giris_btn_Click(object sender, EventArgs e)
        {
            string ad = kullaniciadi_txt.Text;  // Kullanıcının adını al
            string soyad = soyad_txt.Text;  // Kullanıcının soyadını al
            string sifre = sifre_txt.Text;  // Kullanıcının şifresini al

            string rol = string.Empty;
            int kullaniciID = 0; // Giriş yapan kullanıcının ID'si

            if (KullaniciGirisYap(ad, soyad, sifre, out rol, out kullaniciID))
            {
                this.Hide(); // Giriş başarılı, formu gizle

                // Kullanıcı ID'sini global bir değişkene kaydediyoruz
                Global.KullaniciID = kullaniciID;


                // Rolüne göre yönlendir


                if (rol == "Personel")
                {
                    personel personelForm = new personel();
                    personelForm.Show();
                }
                else if (rol == "Üye")
                {
                    uye uyeForm = new uye();
                    uyeForm.Show();
                }
                else
                {
                    MessageBox.Show("Geçersiz rol!");
                }
            }
            else
            {
                MessageBox.Show("Ad, Soyad veya Şifre hatalı.");
            }
        }
        private void kullaniciadi_txt_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
