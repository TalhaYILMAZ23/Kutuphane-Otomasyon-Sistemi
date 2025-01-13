using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane.forms
{
    public partial class KayitOlForm : Form
    {
        public KayitOlForm()
        {
            InitializeComponent();
        }


        private void kayitYap_btn_Click_1(object sender, EventArgs e)
        {
            string ad = ad_txt.Text;
            string soyad = soyad_txt.Text;
            string sifre = sifre_txt.Text;
            string email = email_txt.Text;
            string telefon = telefon_txt.Text;

            // Alanların boş olup olmadığını kontrol et
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(sifre) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefon))
            {
                MessageBox.Show("Tüm alanları doldurun!");
                return;
            }

            // Veritabanına yeni kullanıcı ekleme işlemi
            using (SqlConnection conn = new SqlConnection("Data Source=TALHAY\\SQLEXPRESS03;Initial Catalog=KutuphaneDB;Integrated Security=True;"))
            {
                string query = "INSERT INTO Kullanicilar (Ad, Soyad, Sifre, Email, Telefon, Rol, KayitTarihi) VALUES (@Ad, @Soyad, @Sifre, @Email, @Telefon, 'Üye', GETDATE())";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ad", ad);
                cmd.Parameters.AddWithValue("@Soyad", soyad);
                cmd.Parameters.AddWithValue("@Sifre", sifre);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Telefon", telefon);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarıyla oluşturuldu!");

                this.Close(); // Kayıt işleminden sonra formu kapat
            }
        }
    }
}
