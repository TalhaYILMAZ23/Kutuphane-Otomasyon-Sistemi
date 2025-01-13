using kutuphane;
using kutuphane.forms;
using System;
using System.Windows.Forms;


namespace Kutuphane
{
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde yapılacak işlemler
        private void personel_Load(object sender, EventArgs e)
        {
            // Form yüklenince yapılacak işlemler varsa buraya ekleyebilirsiniz
        }

      
        private void cikis_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kitapyonetimi_btn_Click(object sender, EventArgs e)
        {
            KitapYonetimiForm kitapForm = new KitapYonetimiForm();
            kitapForm.Show();

        }

        private void odunc_iade_btn_Click_1(object sender, EventArgs e)
        {
            OduncIadeForm oduncIadeForm = new OduncIadeForm();
            oduncIadeForm.Show();
        }

        private void uyeyonetim_btn_Click(object sender, EventArgs e)
        {
            UyeYonetimiForm uyeForm = new UyeYonetimiForm();
            uyeForm.Show();
        }

        private void stok_raporlama_btn_Click_1(object sender, EventArgs e)
        {
            var raporlamaForm = new RaporlamaForm();
            raporlamaForm.ShowDialog();
        }
    }
 }

    

