// RaporlamaForm
using System;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using kutuphane.Controllers;
using System.IO;
using kutuphane.models;
using System.Collections.Generic;

namespace Kutuphane
{
    public partial class RaporlamaForm : Form
    {
        private RaporlamaController _raporlamaController;

        public RaporlamaForm()
        {
            InitializeComponent();
            _raporlamaController = new RaporlamaController();
        }

        private void RaporlamaForm_Load_1(object sender, EventArgs e)
        {
            PopulerKitaplariListele();
            AktifUyeleriListele();
        }

        private void PopulerKitaplariListele()
        {
            var kitaplar = _raporlamaController.PopulerKitaplar();
            populer_kitaplar_datagrid.DataSource = kitaplar;

            // Gereksiz sütunları gizle
            if (populer_kitaplar_datagrid.Columns["EnAktifUye"] != null)
                populer_kitaplar_datagrid.Columns["EnAktifUye"].Visible = false;

            if (populer_kitaplar_datagrid.Columns["UyeOduncSayisi"] != null)
                populer_kitaplar_datagrid.Columns["UyeOduncSayisi"].Visible = false;

            if (populer_kitaplar_datagrid.Columns["StokSayisi"] != null)
                populer_kitaplar_datagrid.Columns["StokSayisi"].Visible = false;
        }

        private void AktifUyeleriListele()
        {
            var uyeler = _raporlamaController.AktifUyeler();
            aktif_uyeler_datagrid.DataSource = uyeler;

            // Gereksiz sütunları gizle
            if (aktif_uyeler_datagrid.Columns["KitapAdi"] != null)
                aktif_uyeler_datagrid.Columns["KitapAdi"].Visible = false;

            if (aktif_uyeler_datagrid.Columns["OduncSayisi"] != null)
                aktif_uyeler_datagrid.Columns["OduncSayisi"].Visible = false;

            if (aktif_uyeler_datagrid.Columns["StokSayisi"] != null)
                aktif_uyeler_datagrid.Columns["StokSayisi"].Visible = false;
        }
        private void btn_export_populer_Click_1(object sender, EventArgs e)
        {
            var kitaplar = _raporlamaController.PopulerKitaplar();
            string filePath = "PopulerKitaplar.pdf";
            _raporlamaController.ExportToPdf(kitaplar, filePath, "Popüler Kitaplar");
            MessageBox.Show($"Popüler kitaplar raporu '{filePath}' olarak kaydedildi.");
        }

        private void btn_export_aktif_Click_1(object sender, EventArgs e)
        {
            var uyeler = _raporlamaController.AktifUyeler();
            string filePath = "AktifUyeler.pdf";
            _raporlamaController.ExportToPdf(uyeler, filePath, "En Aktif Üyeler");
            MessageBox.Show($"En aktif üyeler raporu '{filePath}' olarak kaydedildi.");
        }

       

        private void tumkitap_btn_Click(object sender, EventArgs e)
        {
            try
            {
                
                var kitaplar = _raporlamaController.TumKitaplariGetir();
                stok_datagrid.DataSource = kitaplar;
                if (stok_datagrid.Columns["OduncSayisi"] != null)
                    stok_datagrid.Columns["OduncSayisi"].Visible = false;

                if (stok_datagrid.Columns["EnAktifUye"] != null)
                    stok_datagrid.Columns["EnAktifUye"].Visible = false;

                if (stok_datagrid.Columns["UyeOduncSayisi"] != null)
                    stok_datagrid.Columns["UyeOduncSayisi"].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kritik_btn_Click(object sender, EventArgs e)
        {
            try
            {
                
                var kritikKitaplar = _raporlamaController.KritikKitaplariGetir();
                stok_datagrid.DataSource = kritikKitaplar;
                if (stok_datagrid.Columns["OduncSayisi"] != null)
                    stok_datagrid.Columns["OduncSayisi"].Visible = false;

                if (stok_datagrid.Columns["EnAktifUye"] != null)
                    stok_datagrid.Columns["EnAktifUye"].Visible = false;

                if (stok_datagrid.Columns["UyeOduncSayisi"] != null)
                    stok_datagrid.Columns["UyeOduncSayisi"].Visible = false;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stok_pdf_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'deki verileri al
                var kitaplar = stok_datagrid.DataSource as List<RaporModel>;

                // Masaüstü yolunu al
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // Kullanıcıdan dosya adı al
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = desktopPath;
                saveFileDialog.Filter = "PDF Dosyası (*.pdf)|*.pdf";
                saveFileDialog.FileName = "KitaplarRaporu.pdf"; // Varsayılan dosya adı
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Dosya yolunu al
                    string filePath = saveFileDialog.FileName;

                    // PDF belgesini oluştur
                    Document doc = new Document();
                    PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                    doc.Open();

                    // Başlık ekle
                    doc.Add(new Paragraph("Kitaplar Raporu"));
                    doc.Add(new Paragraph(" "));

                    // Tablo oluştur
                    PdfPTable table = new PdfPTable(2); // 2 kolon: Kitap Adı ve Stok Sayısı
                    table.AddCell("Kitap Adi");
                    table.AddCell("Stok Sayisi");

                    // Kitapları tabloya ekle
                    foreach (var kitap in kitaplar)
                    {
                        table.AddCell(kitap.KitapAdi);
                        table.AddCell(kitap.StokSayisi.ToString());
                    }

                    // Tabloyu PDF'ye ekle
                    doc.Add(table);

                    // PDF belgesini kapat
                    doc.Close();

                    MessageBox.Show("PDF başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populer_kitaplar_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
