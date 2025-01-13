using System;
using System.Windows.Forms;
using kutuphane.Controllers;
using kutuphane.models;

namespace Kutuphane
{
    public partial class KitapYonetimiForm : Form
    {
        private KitapController _kitapController;

        public KitapYonetimiForm()
        {
            InitializeComponent();
            _kitapController = new KitapController();
        }

        private void KitapYonetimi_Load(object sender, EventArgs e)
        {
            KitaplariListele();
        }

        private void KitaplariListele()
        {
            var kitaplar = _kitapController.KitaplariGetir();
            kitap_listesi_datagrid.DataSource = kitaplar;
        }


        private void kitap_ekle_btn_Click(object sender, EventArgs e)
        {
            string kitapAdi = kitap_adi_txt.Text;
            string yazarAdi = yazar_adi_txt.Text;
            string kategori = kategori_txt.Text;
            if (int.TryParse(stok_sayisi_txt.Text, out int stokSayisi))
            {
                var kitap = new KitapModel
                {
                    KitapAdi = kitapAdi,
                    YazarAdi = yazarAdi,
                    Kategori = kategori,
                    StokSayisi = stokSayisi
                };

                if (_kitapController.KitapEkle(kitap))
                {
                    MessageBox.Show("Kitap başarıyla eklendi!");
                    KitaplariListele();
                }
                else
                {
                    MessageBox.Show("Kitap eklenirken bir hata oluştu.");
                }
            }
            else
            {
                MessageBox.Show("Stok sayısı geçerli bir sayı olmalıdır.");
            }
        }

        private void kitap_guncelle_btn_Click(object sender, EventArgs e)
        {
            if (kitap_listesi_datagrid.SelectedRows.Count > 0)
            {
                int kitapID = Convert.ToInt32(kitap_listesi_datagrid.SelectedRows[0].Cells[0].Value);
                string kitapAdi = kitap_adi_txt.Text;
                string yazarAdi = yazar_adi_txt.Text;
                string kategori = kategori_txt.Text;
                if (int.TryParse(stok_sayisi_txt.Text, out int stokSayisi))
                {
                    var kitap = new KitapModel
                    {
                        KitapID = kitapID,
                        KitapAdi = kitapAdi,
                        YazarAdi = yazarAdi,
                        Kategori = kategori,
                        StokSayisi = stokSayisi
                    };

                    if (_kitapController.KitapGuncelle(kitap))
                    {
                        MessageBox.Show("Kitap başarıyla güncellendi!");
                        KitaplariListele();
                    }
                    else
                    {
                        MessageBox.Show("Kitap güncellenirken bir hata oluştu.");
                    }
                }
                else
                {
                    MessageBox.Show("Stok sayısı geçerli bir sayı olmalıdır.");
                }
            }
            else
            {
                MessageBox.Show("Güncellenmesi gereken bir kitap seçin.");
            }
        }

        private void kitap_sil_btn_Click_1(object sender, EventArgs e)
        {
            if (kitap_listesi_datagrid.SelectedRows.Count > 0)
            {
                int kitapID = Convert.ToInt32(kitap_listesi_datagrid.SelectedRows[0].Cells[0].Value);

                if (_kitapController.KitapSil(kitapID))
                {
                    MessageBox.Show("Kitap başarıyla silindi!");
                    KitaplariListele();
                }
                else
                {
                    MessageBox.Show("Kitap silinirken bir hata oluştu.");
                }
            }
            else
            {
                MessageBox.Show("Silinecek kitap seçin.");
            }
        }
    }
}
