namespace Kutuphane
{
    partial class KitapYonetimiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapYonetimiForm));
            this.yazar_adi_txt = new System.Windows.Forms.TextBox();
            this.kategori_txt = new System.Windows.Forms.TextBox();
            this.stok_sayisi_txt = new System.Windows.Forms.TextBox();
            this.kitap_adi_lbl = new System.Windows.Forms.Label();
            this.yazar_adi_lbl = new System.Windows.Forms.Label();
            this.kategori_lbl = new System.Windows.Forms.Label();
            this.stok_lbl = new System.Windows.Forms.Label();
            this.kitap_adi_txt = new System.Windows.Forms.TextBox();
            this.kitap_sil_btn = new DevExpress.XtraEditors.SimpleButton();
            this.kitap_ekle_btn = new DevExpress.XtraEditors.SimpleButton();
            this.kitap_guncelle_btn = new DevExpress.XtraEditors.SimpleButton();
            this.kitap_listesi_datagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kitap_listesi_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // yazar_adi_txt
            // 
            this.yazar_adi_txt.BackColor = System.Drawing.SystemColors.Info;
            this.yazar_adi_txt.Location = new System.Drawing.Point(113, 72);
            this.yazar_adi_txt.Name = "yazar_adi_txt";
            this.yazar_adi_txt.Size = new System.Drawing.Size(213, 22);
            this.yazar_adi_txt.TabIndex = 1;
            // 
            // kategori_txt
            // 
            this.kategori_txt.BackColor = System.Drawing.SystemColors.Info;
            this.kategori_txt.Location = new System.Drawing.Point(113, 111);
            this.kategori_txt.Name = "kategori_txt";
            this.kategori_txt.Size = new System.Drawing.Size(213, 22);
            this.kategori_txt.TabIndex = 2;
            // 
            // stok_sayisi_txt
            // 
            this.stok_sayisi_txt.BackColor = System.Drawing.SystemColors.Info;
            this.stok_sayisi_txt.Location = new System.Drawing.Point(113, 152);
            this.stok_sayisi_txt.Name = "stok_sayisi_txt";
            this.stok_sayisi_txt.Size = new System.Drawing.Size(213, 22);
            this.stok_sayisi_txt.TabIndex = 3;
            // 
            // kitap_adi_lbl
            // 
            this.kitap_adi_lbl.AutoSize = true;
            this.kitap_adi_lbl.Location = new System.Drawing.Point(34, 33);
            this.kitap_adi_lbl.Name = "kitap_adi_lbl";
            this.kitap_adi_lbl.Size = new System.Drawing.Size(66, 16);
            this.kitap_adi_lbl.TabIndex = 11;
            this.kitap_adi_lbl.Text = "Kitap Adı :";
            // 
            // yazar_adi_lbl
            // 
            this.yazar_adi_lbl.AutoSize = true;
            this.yazar_adi_lbl.Location = new System.Drawing.Point(34, 75);
            this.yazar_adi_lbl.Name = "yazar_adi_lbl";
            this.yazar_adi_lbl.Size = new System.Drawing.Size(71, 16);
            this.yazar_adi_lbl.TabIndex = 2;
            this.yazar_adi_lbl.Text = "Yazar Adı :";
            // 
            // kategori_lbl
            // 
            this.kategori_lbl.AutoSize = true;
            this.kategori_lbl.Location = new System.Drawing.Point(34, 111);
            this.kategori_lbl.Name = "kategori_lbl";
            this.kategori_lbl.Size = new System.Drawing.Size(63, 16);
            this.kategori_lbl.TabIndex = 3;
            this.kategori_lbl.Text = "Kategori :";
            // 
            // stok_lbl
            // 
            this.stok_lbl.AutoSize = true;
            this.stok_lbl.Location = new System.Drawing.Point(34, 153);
            this.stok_lbl.Name = "stok_lbl";
            this.stok_lbl.Size = new System.Drawing.Size(40, 16);
            this.stok_lbl.TabIndex = 4;
            this.stok_lbl.Text = "Stok :";
            // 
            // kitap_adi_txt
            // 
            this.kitap_adi_txt.BackColor = System.Drawing.SystemColors.Info;
            this.kitap_adi_txt.Location = new System.Drawing.Point(113, 33);
            this.kitap_adi_txt.Name = "kitap_adi_txt";
            this.kitap_adi_txt.Size = new System.Drawing.Size(213, 22);
            this.kitap_adi_txt.TabIndex = 0;
            // 
            // kitap_sil_btn
            // 
            this.kitap_sil_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kitap_sil_btn.ImageOptions.Image")));
            this.kitap_sil_btn.Location = new System.Drawing.Point(217, 213);
            this.kitap_sil_btn.Name = "kitap_sil_btn";
            this.kitap_sil_btn.Size = new System.Drawing.Size(109, 47);
            this.kitap_sil_btn.TabIndex = 12;
            this.kitap_sil_btn.Text = "Sil";
            this.kitap_sil_btn.Click += new System.EventHandler(this.kitap_sil_btn_Click_1);
            // 
            // kitap_ekle_btn
            // 
            this.kitap_ekle_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kitap_ekle_btn.ImageOptions.Image")));
            this.kitap_ekle_btn.Location = new System.Drawing.Point(113, 213);
            this.kitap_ekle_btn.Name = "kitap_ekle_btn";
            this.kitap_ekle_btn.Size = new System.Drawing.Size(98, 47);
            this.kitap_ekle_btn.TabIndex = 12;
            this.kitap_ekle_btn.Text = "Ekle";
            this.kitap_ekle_btn.Click += new System.EventHandler(this.kitap_ekle_btn_Click);
            // 
            // kitap_guncelle_btn
            // 
            this.kitap_guncelle_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kitap_guncelle_btn.ImageOptions.Image")));
            this.kitap_guncelle_btn.Location = new System.Drawing.Point(217, 279);
            this.kitap_guncelle_btn.Name = "kitap_guncelle_btn";
            this.kitap_guncelle_btn.Size = new System.Drawing.Size(109, 47);
            this.kitap_guncelle_btn.TabIndex = 12;
            this.kitap_guncelle_btn.Text = "Güncelle";
            this.kitap_guncelle_btn.Click += new System.EventHandler(this.kitap_guncelle_btn_Click);
            // 
            // kitap_listesi_datagrid
            // 
            this.kitap_listesi_datagrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.kitap_listesi_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitap_listesi_datagrid.Location = new System.Drawing.Point(368, 33);
            this.kitap_listesi_datagrid.Name = "kitap_listesi_datagrid";
            this.kitap_listesi_datagrid.RowHeadersWidth = 51;
            this.kitap_listesi_datagrid.RowTemplate.Height = 24;
            this.kitap_listesi_datagrid.Size = new System.Drawing.Size(764, 293);
            this.kitap_listesi_datagrid.TabIndex = 0;
            // 
            // KitapYonetimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1167, 391);
            this.Controls.Add(this.kitap_guncelle_btn);
            this.Controls.Add(this.kitap_ekle_btn);
            this.Controls.Add(this.kitap_sil_btn);
            this.Controls.Add(this.kitap_listesi_datagrid);
            this.Controls.Add(this.stok_lbl);
            this.Controls.Add(this.yazar_adi_lbl);
            this.Controls.Add(this.kategori_lbl);
            this.Controls.Add(this.kitap_adi_lbl);
            this.Controls.Add(this.stok_sayisi_txt);
            this.Controls.Add(this.kategori_txt);
            this.Controls.Add(this.kitap_adi_txt);
            this.Controls.Add(this.yazar_adi_txt);
            this.Name = "KitapYonetimiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapYonetimi";
            this.Load += new System.EventHandler(this.KitapYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitap_listesi_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox yazar_adi_txt;
        private System.Windows.Forms.TextBox kategori_txt;
        private System.Windows.Forms.TextBox stok_sayisi_txt;
        private System.Windows.Forms.Label kitap_adi_lbl;
        private System.Windows.Forms.Label yazar_adi_lbl;
        private System.Windows.Forms.Label kategori_lbl;
        private System.Windows.Forms.Label stok_lbl;
        private System.Windows.Forms.TextBox kitap_adi_txt;
        private DevExpress.XtraEditors.SimpleButton kitap_sil_btn;
        private DevExpress.XtraEditors.SimpleButton kitap_ekle_btn;
        private DevExpress.XtraEditors.SimpleButton kitap_guncelle_btn;
        private System.Windows.Forms.DataGridView kitap_listesi_datagrid;
    }
}