namespace kutuphane.forms
{
    partial class KayitOlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitOlForm));
            this.ad_txt = new System.Windows.Forms.TextBox();
            this.soyad_txt = new System.Windows.Forms.TextBox();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.telefon_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.soyad_lbl = new System.Windows.Forms.Label();
            this.sifre_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.telefon_lbl = new System.Windows.Forms.Label();
            this.ad_lbl = new System.Windows.Forms.Label();
            this.kayitYap_btn = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // ad_txt
            // 
            this.ad_txt.BackColor = System.Drawing.SystemColors.Info;
            this.ad_txt.Location = new System.Drawing.Point(195, 65);
            this.ad_txt.Name = "ad_txt";
            this.ad_txt.Size = new System.Drawing.Size(177, 22);
            this.ad_txt.TabIndex = 0;
            // 
            // soyad_txt
            // 
            this.soyad_txt.BackColor = System.Drawing.SystemColors.Info;
            this.soyad_txt.Location = new System.Drawing.Point(195, 112);
            this.soyad_txt.Name = "soyad_txt";
            this.soyad_txt.Size = new System.Drawing.Size(177, 22);
            this.soyad_txt.TabIndex = 1;
            // 
            // sifre_txt
            // 
            this.sifre_txt.BackColor = System.Drawing.SystemColors.Info;
            this.sifre_txt.Location = new System.Drawing.Point(195, 154);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.Size = new System.Drawing.Size(177, 22);
            this.sifre_txt.TabIndex = 2;
            // 
            // telefon_txt
            // 
            this.telefon_txt.BackColor = System.Drawing.SystemColors.Info;
            this.telefon_txt.Location = new System.Drawing.Point(195, 243);
            this.telefon_txt.Name = "telefon_txt";
            this.telefon_txt.Size = new System.Drawing.Size(177, 22);
            this.telefon_txt.TabIndex = 4;
            // 
            // email_txt
            // 
            this.email_txt.BackColor = System.Drawing.SystemColors.Info;
            this.email_txt.Location = new System.Drawing.Point(195, 200);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(177, 22);
            this.email_txt.TabIndex = 3;
            // 
            // soyad_lbl
            // 
            this.soyad_lbl.AutoSize = true;
            this.soyad_lbl.Location = new System.Drawing.Point(118, 112);
            this.soyad_lbl.Name = "soyad_lbl";
            this.soyad_lbl.Size = new System.Drawing.Size(57, 16);
            this.soyad_lbl.TabIndex = 1;
            this.soyad_lbl.Text = "Soy Ad :";
            // 
            // sifre_lbl
            // 
            this.sifre_lbl.AutoSize = true;
            this.sifre_lbl.Location = new System.Drawing.Point(132, 154);
            this.sifre_lbl.Name = "sifre_lbl";
            this.sifre_lbl.Size = new System.Drawing.Size(40, 16);
            this.sifre_lbl.TabIndex = 1;
            this.sifre_lbl.Text = "Şifre :";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Location = new System.Drawing.Point(125, 200);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(47, 16);
            this.email_lbl.TabIndex = 1;
            this.email_lbl.Text = "Email :";
            // 
            // telefon_lbl
            // 
            this.telefon_lbl.AutoSize = true;
            this.telefon_lbl.Location = new System.Drawing.Point(115, 243);
            this.telefon_lbl.Name = "telefon_lbl";
            this.telefon_lbl.Size = new System.Drawing.Size(59, 16);
            this.telefon_lbl.TabIndex = 1;
            this.telefon_lbl.Text = "Telefon :";
            // 
            // ad_lbl
            // 
            this.ad_lbl.AutoSize = true;
            this.ad_lbl.Location = new System.Drawing.Point(140, 65);
            this.ad_lbl.Name = "ad_lbl";
            this.ad_lbl.Size = new System.Drawing.Size(32, 16);
            this.ad_lbl.TabIndex = 1;
            this.ad_lbl.Text = "AD :";
            // 
            // kayitYap_btn
            // 
            this.kayitYap_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kayitYap_btn.ImageOptions.Image")));
            this.kayitYap_btn.Location = new System.Drawing.Point(216, 310);
            this.kayitYap_btn.Name = "kayitYap_btn";
            this.kayitYap_btn.Size = new System.Drawing.Size(156, 44);
            this.kayitYap_btn.TabIndex = 6;
            this.kayitYap_btn.Text = "Kayıt Ol";
            this.kayitYap_btn.Click += new System.EventHandler(this.kayitYap_btn_Click_1);
            // 
            // KayitOlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(510, 398);
            this.Controls.Add(this.kayitYap_btn);
            this.Controls.Add(this.telefon_lbl);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.ad_lbl);
            this.Controls.Add(this.soyad_lbl);
            this.Controls.Add(this.sifre_lbl);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.telefon_txt);
            this.Controls.Add(this.soyad_txt);
            this.Controls.Add(this.sifre_txt);
            this.Controls.Add(this.ad_txt);
            this.Name = "KayitOlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayitOlForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ad_txt;
        private System.Windows.Forms.TextBox soyad_txt;
        private System.Windows.Forms.TextBox sifre_txt;
        private System.Windows.Forms.TextBox telefon_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label soyad_lbl;
        private System.Windows.Forms.Label sifre_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label telefon_lbl;
        private System.Windows.Forms.Label ad_lbl;
        private DevExpress.XtraEditors.SimpleButton kayitYap_btn;
    }
}