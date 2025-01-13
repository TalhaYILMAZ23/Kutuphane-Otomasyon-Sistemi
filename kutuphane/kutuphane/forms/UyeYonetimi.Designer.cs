namespace Kutuphane
{
    partial class UyeYonetimiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeYonetimiForm));
            this.ad_txt = new System.Windows.Forms.TextBox();
            this.soyad_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.telefon_txt = new System.Windows.Forms.TextBox();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.email_lbl = new System.Windows.Forms.Label();
            this.telefon_lbl = new System.Windows.Forms.Label();
            this.ad_lbl = new System.Windows.Forms.Label();
            this.soyad_lbl = new System.Windows.Forms.Label();
            this.sifre_lbl = new System.Windows.Forms.Label();
            this.uye_listesi_datagrid = new System.Windows.Forms.DataGridView();
            this.uye_ekle_btn = new DevExpress.XtraEditors.SimpleButton();
            this.uye_sil_btn = new DevExpress.XtraEditors.SimpleButton();
            this.uye_guncelle_btn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.uye_listesi_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ad_txt
            // 
            this.ad_txt.BackColor = System.Drawing.SystemColors.Info;
            this.ad_txt.Location = new System.Drawing.Point(93, 33);
            this.ad_txt.Name = "ad_txt";
            this.ad_txt.Size = new System.Drawing.Size(246, 22);
            this.ad_txt.TabIndex = 0;
            this.ad_txt.TextChanged += new System.EventHandler(this.ad_txt_TextChanged);
            // 
            // soyad_txt
            // 
            this.soyad_txt.BackColor = System.Drawing.SystemColors.Info;
            this.soyad_txt.Location = new System.Drawing.Point(93, 71);
            this.soyad_txt.Name = "soyad_txt";
            this.soyad_txt.Size = new System.Drawing.Size(246, 22);
            this.soyad_txt.TabIndex = 1;
            // 
            // email_txt
            // 
            this.email_txt.BackColor = System.Drawing.SystemColors.Info;
            this.email_txt.Location = new System.Drawing.Point(93, 111);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(246, 22);
            this.email_txt.TabIndex = 2;
            // 
            // telefon_txt
            // 
            this.telefon_txt.BackColor = System.Drawing.SystemColors.Info;
            this.telefon_txt.Location = new System.Drawing.Point(93, 152);
            this.telefon_txt.Name = "telefon_txt";
            this.telefon_txt.Size = new System.Drawing.Size(246, 22);
            this.telefon_txt.TabIndex = 3;
            // 
            // sifre_txt
            // 
            this.sifre_txt.BackColor = System.Drawing.SystemColors.Info;
            this.sifre_txt.Location = new System.Drawing.Point(93, 196);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.Size = new System.Drawing.Size(246, 22);
            this.sifre_txt.TabIndex = 4;
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Location = new System.Drawing.Point(28, 114);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(47, 16);
            this.email_lbl.TabIndex = 2;
            this.email_lbl.Text = "Email :";
            // 
            // telefon_lbl
            // 
            this.telefon_lbl.AutoSize = true;
            this.telefon_lbl.Location = new System.Drawing.Point(17, 155);
            this.telefon_lbl.Name = "telefon_lbl";
            this.telefon_lbl.Size = new System.Drawing.Size(59, 16);
            this.telefon_lbl.TabIndex = 2;
            this.telefon_lbl.Text = "Telefon :";
            // 
            // ad_lbl
            // 
            this.ad_lbl.AutoSize = true;
            this.ad_lbl.Location = new System.Drawing.Point(40, 33);
            this.ad_lbl.Name = "ad_lbl";
            this.ad_lbl.Size = new System.Drawing.Size(30, 16);
            this.ad_lbl.TabIndex = 2;
            this.ad_lbl.Text = "Ad :";
            // 
            // soyad_lbl
            // 
            this.soyad_lbl.AutoSize = true;
            this.soyad_lbl.Location = new System.Drawing.Point(20, 77);
            this.soyad_lbl.Name = "soyad_lbl";
            this.soyad_lbl.Size = new System.Drawing.Size(57, 16);
            this.soyad_lbl.TabIndex = 2;
            this.soyad_lbl.Text = "Soy Ad :";
            // 
            // sifre_lbl
            // 
            this.sifre_lbl.AutoSize = true;
            this.sifre_lbl.Location = new System.Drawing.Point(37, 196);
            this.sifre_lbl.Name = "sifre_lbl";
            this.sifre_lbl.Size = new System.Drawing.Size(40, 16);
            this.sifre_lbl.TabIndex = 2;
            this.sifre_lbl.Text = "Şifre :";
            // 
            // uye_listesi_datagrid
            // 
            this.uye_listesi_datagrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.uye_listesi_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uye_listesi_datagrid.Location = new System.Drawing.Point(385, 33);
            this.uye_listesi_datagrid.Name = "uye_listesi_datagrid";
            this.uye_listesi_datagrid.RowHeadersWidth = 51;
            this.uye_listesi_datagrid.RowTemplate.Height = 24;
            this.uye_listesi_datagrid.Size = new System.Drawing.Size(728, 288);
            this.uye_listesi_datagrid.TabIndex = 0;
            // 
            // uye_ekle_btn
            // 
            this.uye_ekle_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.uye_ekle_btn.Location = new System.Drawing.Point(93, 252);
            this.uye_ekle_btn.Name = "uye_ekle_btn";
            this.uye_ekle_btn.Size = new System.Drawing.Size(117, 41);
            this.uye_ekle_btn.TabIndex = 8;
            this.uye_ekle_btn.Text = "Ekle";
            this.uye_ekle_btn.Click += new System.EventHandler(this.uye_ekle_btn_Click_1);
            // 
            // uye_sil_btn
            // 
            this.uye_sil_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.uye_sil_btn.Location = new System.Drawing.Point(218, 252);
            this.uye_sil_btn.Name = "uye_sil_btn";
            this.uye_sil_btn.Size = new System.Drawing.Size(121, 41);
            this.uye_sil_btn.TabIndex = 9;
            this.uye_sil_btn.Text = "Sil";
            this.uye_sil_btn.Click += new System.EventHandler(this.uye_sil_btn_Click);
            // 
            // uye_guncelle_btn
            // 
            this.uye_guncelle_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.uye_guncelle_btn.Location = new System.Drawing.Point(218, 312);
            this.uye_guncelle_btn.Name = "uye_guncelle_btn";
            this.uye_guncelle_btn.Size = new System.Drawing.Size(121, 41);
            this.uye_guncelle_btn.TabIndex = 10;
            this.uye_guncelle_btn.Text = "Güncelle";
            this.uye_guncelle_btn.Click += new System.EventHandler(this.uye_guncelle_btn_Click);
            // 
            // UyeYonetimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1152, 432);
            this.Controls.Add(this.uye_guncelle_btn);
            this.Controls.Add(this.uye_sil_btn);
            this.Controls.Add(this.uye_ekle_btn);
            this.Controls.Add(this.uye_listesi_datagrid);
            this.Controls.Add(this.soyad_lbl);
            this.Controls.Add(this.sifre_lbl);
            this.Controls.Add(this.telefon_lbl);
            this.Controls.Add(this.ad_lbl);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.sifre_txt);
            this.Controls.Add(this.telefon_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.soyad_txt);
            this.Controls.Add(this.ad_txt);
            this.Name = "UyeYonetimiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeYonetimi";
            this.Load += new System.EventHandler(this.UyeYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uye_listesi_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ad_txt;
        private System.Windows.Forms.TextBox soyad_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox telefon_txt;
        private System.Windows.Forms.TextBox sifre_txt;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label telefon_lbl;
        private System.Windows.Forms.Label ad_lbl;
        private System.Windows.Forms.Label soyad_lbl;
        private System.Windows.Forms.Label sifre_lbl;
        private System.Windows.Forms.DataGridView uye_listesi_datagrid;
        private DevExpress.XtraEditors.SimpleButton uye_ekle_btn;
        private DevExpress.XtraEditors.SimpleButton uye_sil_btn;
        private DevExpress.XtraEditors.SimpleButton uye_guncelle_btn;
    }
}