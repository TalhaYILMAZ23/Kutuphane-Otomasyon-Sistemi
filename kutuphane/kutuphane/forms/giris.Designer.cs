namespace kutuphane
{
    partial class giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.kullaniciadi_txt = new System.Windows.Forms.TextBox();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.kullaniciadi_lbl = new System.Windows.Forms.Label();
            this.sifre_lbl = new System.Windows.Forms.Label();
            this.soyad_txt = new System.Windows.Forms.TextBox();
            this.soyad_lbl = new System.Windows.Forms.Label();
            this.giris_btn = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kayitOl_btn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciadi_txt
            // 
            this.kullaniciadi_txt.BackColor = System.Drawing.SystemColors.Info;
            this.kullaniciadi_txt.Location = new System.Drawing.Point(449, 101);
            this.kullaniciadi_txt.Name = "kullaniciadi_txt";
            this.kullaniciadi_txt.Size = new System.Drawing.Size(181, 22);
            this.kullaniciadi_txt.TabIndex = 0;
            this.kullaniciadi_txt.TextChanged += new System.EventHandler(this.kullaniciadi_txt_TextChanged);
            // 
            // sifre_txt
            // 
            this.sifre_txt.BackColor = System.Drawing.SystemColors.Info;
            this.sifre_txt.Location = new System.Drawing.Point(449, 182);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.PasswordChar = '*';
            this.sifre_txt.Size = new System.Drawing.Size(181, 22);
            this.sifre_txt.TabIndex = 2;
            // 
            // kullaniciadi_lbl
            // 
            this.kullaniciadi_lbl.AutoSize = true;
            this.kullaniciadi_lbl.Location = new System.Drawing.Point(406, 101);
            this.kullaniciadi_lbl.Name = "kullaniciadi_lbl";
            this.kullaniciadi_lbl.Size = new System.Drawing.Size(30, 16);
            this.kullaniciadi_lbl.TabIndex = 2;
            this.kullaniciadi_lbl.Text = "Ad :";
            // 
            // sifre_lbl
            // 
            this.sifre_lbl.AutoSize = true;
            this.sifre_lbl.Location = new System.Drawing.Point(406, 182);
            this.sifre_lbl.Name = "sifre_lbl";
            this.sifre_lbl.Size = new System.Drawing.Size(37, 16);
            this.sifre_lbl.TabIndex = 2;
            this.sifre_lbl.Text = "Şifre:";
            // 
            // soyad_txt
            // 
            this.soyad_txt.BackColor = System.Drawing.SystemColors.Info;
            this.soyad_txt.Location = new System.Drawing.Point(449, 138);
            this.soyad_txt.Name = "soyad_txt";
            this.soyad_txt.Size = new System.Drawing.Size(181, 22);
            this.soyad_txt.TabIndex = 1;
            // 
            // soyad_lbl
            // 
            this.soyad_lbl.AutoSize = true;
            this.soyad_lbl.Location = new System.Drawing.Point(386, 141);
            this.soyad_lbl.Name = "soyad_lbl";
            this.soyad_lbl.Size = new System.Drawing.Size(57, 16);
            this.soyad_lbl.TabIndex = 2;
            this.soyad_lbl.Text = "Soy Ad :";
            // 
            // giris_btn
            // 
            this.giris_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("giris_btn.ImageOptions.Image")));
            this.giris_btn.Location = new System.Drawing.Point(482, 225);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(148, 42);
            this.giris_btn.TabIndex = 5;
            this.giris_btn.Text = "Giriş Yap";
            this.giris_btn.Click += new System.EventHandler(this.giris_btn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "user.png");
            this.ımageList1.Images.SetKeyName(1, "285648_group_user_icon.ico");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // kayitOl_btn
            // 
            this.kayitOl_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kayitOl_btn.ImageOptions.Image")));
            this.kayitOl_btn.Location = new System.Drawing.Point(482, 277);
            this.kayitOl_btn.Name = "kayitOl_btn";
            this.kayitOl_btn.Size = new System.Drawing.Size(148, 42);
            this.kayitOl_btn.TabIndex = 7;
            this.kayitOl_btn.Text = "Kayıt Ol";
            this.kayitOl_btn.Click += new System.EventHandler(this.kayitOl_btn_Click_1);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(736, 437);
            this.Controls.Add(this.kayitOl_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.giris_btn);
            this.Controls.Add(this.sifre_lbl);
            this.Controls.Add(this.soyad_lbl);
            this.Controls.Add(this.kullaniciadi_lbl);
            this.Controls.Add(this.sifre_txt);
            this.Controls.Add(this.soyad_txt);
            this.Controls.Add(this.kullaniciadi_txt);
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullaniciadi_txt;
        private System.Windows.Forms.TextBox sifre_txt;
        private System.Windows.Forms.Label kullaniciadi_lbl;
        private System.Windows.Forms.Label sifre_lbl;
        private System.Windows.Forms.TextBox soyad_txt;
        private System.Windows.Forms.Label soyad_lbl;
        private DevExpress.XtraEditors.SimpleButton giris_btn;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton kayitOl_btn;
    }
}

