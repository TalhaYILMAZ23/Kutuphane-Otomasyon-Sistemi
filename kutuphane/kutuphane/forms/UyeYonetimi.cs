using System;
using System.Windows.Forms;
using kutuphane.Controllers;
using kutuphane.models;
using System.Linq;

namespace Kutuphane
{
    public partial class UyeYonetimiForm : Form
    {
        private UyeYonetimController _uyeYonetimController;

        public UyeYonetimiForm()
        {
            InitializeComponent();
            _uyeYonetimController = new UyeYonetimController();
        }

        private void UyeYonetimi_Load(object sender, EventArgs e)
        {
            UyeListele();
        }

        private void UyeListele()
        {
            var uyeListesi = _uyeYonetimController.UyeListele();
            uye_listesi_datagrid.DataSource = uyeListesi;
        }


        private void uye_listesi_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = uye_listesi_datagrid.Rows[e.RowIndex];
                ad_txt.Text = row.Cells["Ad"].Value.ToString();
                soyad_txt.Text = row.Cells["Soyad"].Value.ToString();
                email_txt.Text = row.Cells["Email"].Value.ToString();
                telefon_txt.Text = row.Cells["Telefon"].Value.ToString();
                sifre_txt.Text = ""; // Şifreyi boş bırakıyoruz
            }
        }
        private void ad_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void uye_ekle_btn_Click_1(object sender, EventArgs e)
        {
            var yeniUye = new UyeYonetimModel
            {
                Ad = ad_txt.Text,
                Soyad = soyad_txt.Text,
                Email = email_txt.Text,
                Telefon = telefon_txt.Text,
                Sifre = sifre_txt.Text
            };

            _uyeYonetimController.UyeEkle(yeniUye);
            MessageBox.Show("Üye başarıyla eklendi!");
            UyeListele();
        }

        private void uye_sil_btn_Click(object sender, EventArgs e)
        {
            if (uye_listesi_datagrid.SelectedRows.Count > 0)
            {
                int kullaniciID = Convert.ToInt32(uye_listesi_datagrid.SelectedRows[0].Cells["KullaniciID"].Value);
                _uyeYonetimController.UyeSil(kullaniciID);
                MessageBox.Show("Üye başarıyla silindi!");
                UyeListele();
            }
            else
            {
                MessageBox.Show("Silinecek bir üye seçin.");
            }
        }

        private void uye_guncelle_btn_Click(object sender, EventArgs e)
        {
            if (uye_listesi_datagrid.SelectedRows.Count > 0)
            {
                var guncelUye = new UyeYonetimModel
                {
                    KullaniciID = Convert.ToInt32(uye_listesi_datagrid.SelectedRows[0].Cells["KullaniciID"].Value),
                    Ad = ad_txt.Text,
                    Soyad = soyad_txt.Text,
                    Email = email_txt.Text,
                    Telefon = telefon_txt.Text,
                    Sifre = sifre_txt.Text
                };

                _uyeYonetimController.UyeGuncelle(guncelUye);
                MessageBox.Show("Üye başarıyla güncellendi!");
                UyeListele();
            }
            else
            {
                MessageBox.Show("Güncellenecek bir üye seçin.");
            }
        }
    }
}
