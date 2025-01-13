using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using kutuphane.Controllers;
using kutuphane.models;
using static DevExpress.Utils.Svg.CommonSvgImages;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;

namespace Kutuphane
{
    public partial class OduncIadeForm : Form
    {
        private KitapController _kitapController;
        private OduncController _oduncController;
        private DataTable uyelerDataTable;
        private bool isFiltering = false;
        private List<KitapModel> tumKitaplar;
        public OduncIadeForm()
        {
            InitializeComponent();
            _kitapController = new KitapController();
            _oduncController = new OduncController();
        }

        private void OduncIade_Load(object sender, EventArgs e)
        {
            KitaplariListele();
            UyeleriListele();
        }

        private void KitaplariListele()
        {
            tumKitaplar = _kitapController.KitaplariGetir();
            var kitaplar = _kitapController.KitaplariGetir();
            kitap_arama_cb.DataSource = kitaplar;
            kitap_arama_cb.DisplayMember = "KitapAdi";
            kitap_arama_cb.ValueMember = "KitapID";
            kitap_arama_cb.DropDownStyle = ComboBoxStyle.DropDown;
        }
        private void kitap_arama_cb_TextChanged_1(object sender, EventArgs e)
        {
            if (isFiltering) return; // Sonsuz döngüyü engelle

            if (tumKitaplar == null) return;

            isFiltering = true; // Filtreleme başlatıldığında flag'i true yap

            string filterText = kitap_arama_cb.Text.ToLower();

            // Filtreleme işlemi, KitapAdi'nda filterText'i içeren kitapları buluyor
            var filteredBooks = tumKitaplar
                .Where(k => k.KitapAdi.ToLower().Contains(filterText))
                .ToList();

            // Filtrelenmiş listeyi ComboBox'a bağla
            kitap_arama_cb.DataSource = filteredBooks;
            kitap_arama_cb.DisplayMember = "KitapAdi";
            kitap_arama_cb.ValueMember = "KitapID";

            // Yazıyı koruma
            kitap_arama_cb.Text = filterText;
            kitap_arama_cb.SelectionStart = filterText.Length;
            kitap_arama_cb.SelectionLength = 0;

            // Dropdown açık tutma
            kitap_arama_cb.DroppedDown = true;

            isFiltering = false; // Filtreleme bitince flag'i false yap
        }

        private void UyeleriListele()
        {
            string connectionString = "Data Source=TALHAY\\SQLEXPRESS03;Initial Catalog=KutuphaneDB;Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT 
                    KullaniciID, 
                    CONCAT(Ad, ' ', Soyad) AS AdSoyad 
                FROM 
                    Kullanicilar 
                WHERE 
                    Rol = 'Üye'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    uyelerDataTable = new DataTable(); // DataTable'ı global alanda saklıyoruz.
                    da.Fill(uyelerDataTable);

                    // İlk listeleme
                    uye_secin_cb.DataSource = uyelerDataTable;
                    uye_secin_cb.DisplayMember = "AdSoyad";
                    uye_secin_cb.ValueMember = "KullaniciID";
                    uye_secin_cb.DropDownStyle = ComboBoxStyle.DropDown;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Üyeler listelenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK);
            }
        }

        private void uye_secin_cb_TextChanged(object sender, EventArgs e)
        {
            if (uyelerDataTable == null || isFiltering) return;

            try
            {
                isFiltering = true; // Filtreleme işlemi sırasında olayı devre dışı bırak

                string filterText = uye_secin_cb.Text;

                // Filtreleme yapılır, mevcut metin değiştirilmez.
                DataView filteredView = new DataView(uyelerDataTable)
                {
                    RowFilter = $"AdSoyad LIKE '%{filterText}%'"
                };

                // ComboBox öğelerini yeniden doldur
                uye_secin_cb.DataSource = filteredView;
                uye_secin_cb.DisplayMember = "AdSoyad";
                uye_secin_cb.ValueMember = "KullaniciID";

                // Kullanıcının yazdığı metni koruyalım
                uye_secin_cb.Text = filterText;
                uye_secin_cb.SelectionStart = filterText.Length;
                uye_secin_cb.SelectionLength = 0;

                // Dropdown açık olsun (isteğe bağlı)
                uye_secin_cb.DroppedDown = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filtreleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK);
            }
            finally
            {
                isFiltering = false; // Filtreleme işlemi tamamlandıktan sonra olayı yeniden etkinleştir
            }
        }

        private void OduncKitaplariListele(int kullaniciID)
        {
            var oduncKitaplar = _oduncController.OduncKitaplariGetir(kullaniciID);
            odunc_kitaplar_datagridd.DataSource = oduncKitaplar;
        }

        private void uye_secin_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int kullaniciID = Convert.ToInt32(uye_secin_cb.SelectedValue);
            OduncKitaplariListele(kullaniciID);
        }

        private void iade_ver_btn_Click(object sender, EventArgs e)
        {
            int kullaniciID = Convert.ToInt32(uye_secin_cb.SelectedValue);
            int kitapID = Convert.ToInt32(kitap_arama_cb.SelectedValue);

            if (_oduncController.IadeAl(kullaniciID, kitapID))
            {
                MessageBox.Show("Kitap iade alındı!");
                OduncKitaplariListele(kullaniciID);
            }
            else
            {
                MessageBox.Show("Kitap iade işlemi başarısız oldu!");
            }
        }

        private void odunc_ver_btn_Click_1(object sender, EventArgs e)
        {
            int kullaniciID = Convert.ToInt32(uye_secin_cb.SelectedValue);
            int kitapID = Convert.ToInt32(kitap_arama_cb.SelectedValue);

            if (_oduncController.OduncVer(kullaniciID, kitapID))
            {
                MessageBox.Show("Kitap ödünç verildi!");
                OduncKitaplariListele(kullaniciID);
            }
            else
            {
                MessageBox.Show("Kitap ödünç verme işlemi başarısız oldu!");
            }
        }

        private void odunc_kitaplari_getir_btn_Click_1(object sender, EventArgs e)
        {
            var cezaController = new CezaKontrolController();
            cezaController.CezaKontrolu();

            int kullaniciID = Convert.ToInt32(uye_secin_cb.SelectedValue);
            OduncKitaplariListele(kullaniciID);
        }

       
    }
}
