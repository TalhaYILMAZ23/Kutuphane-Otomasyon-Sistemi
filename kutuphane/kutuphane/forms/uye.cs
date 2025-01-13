using kutuphane.Controllers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class uye : Form
    {
        private RaporlamaController _raporlamaController;
        public uye()
        {
            InitializeComponent();
            _raporlamaController = new RaporlamaController();
        }

        // Form yüklendiğinde ödünç kitapları listelemek için çağırıyoruz
        private void uye_Load_1(object sender, EventArgs e)
        {
            OduncKitaplariListele();
            PopulerKitaplariGoster();

        }

        // Giriş yapan kullanıcının ödünç aldığı kitapları listeleyen fonksiyon
        private void OduncKitaplariListele()
        {
            // Global değişkenden KullaniciID'yi alıyoruz
            int kullaniciID = Global.KullaniciID;

            // Veritabanı bağlantısı
            using (SqlConnection conn = new SqlConnection("Data Source=TALHAY\\SQLEXPRESS03;Initial Catalog=KutuphaneDB;Integrated Security=True;"))
            {
                // OduncKitaplar tablosunda sorgu yapıyoruz
                string query = "SELECT k.KitapAdi, o.OduncTarihi, o.IadeTarihi " +
                               "FROM OduncKitaplar o " +
                               "JOIN Kitaplar k ON o.KitapID = k.KitapID " +
                               "WHERE o.KullaniciID = @KullaniciID";  // Kullanıcı ID'sine göre sorgu

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);  // KullaniciID'yi parametre olarak ekliyoruz

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Eğer ödünç kitap yoksa kullanıcıya bildirelim
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Ödünç alınan kitap bulunamadı.");
                }

                // DataGridView'e verileri yansıtalım
                odunckitaplist_datagridd.DataSource = dt;
            }
        } 
        private void PopulerKitaplariGoster()
        {
            var kitaplar = _raporlamaController.PopulerKitaplar();           
            populer_kitaplar_listboxx.DataSource = kitaplar;
            populer_kitaplar_listboxx.DisplayMember = "KitapAdi";
        }

        private void kitaparama_ara_btn_Click_1(object sender, EventArgs e)
        {
            string kitapAdi = kitap_arama_txt.Text; // Kullanıcıdan kitap adı alıyoruz

            // Veritabanı bağlantısı
            using (SqlConnection conn = new SqlConnection("Data Source=TALHAY\\SQLEXPRESS03;Initial Catalog=KutuphaneDB;Integrated Security=True;"))
            {
                // Kitap arama sorgusu
                string query = "SELECT KitapAdi, YazarAdi, Kategori FROM Kitaplar WHERE KitapAdi LIKE @KitapAdi";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KitapAdi", "%" + kitapAdi + "%");  // Arama yapılacak kitap adı

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Arama sonuçlarını DataGridView'e yansıtalım
               
                kitaparama_datagridd.DataSource = dt;
            }
        }
    }
}

