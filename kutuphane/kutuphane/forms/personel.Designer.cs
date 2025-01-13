namespace Kutuphane
{
    partial class personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personel));
            this.cikis_btn = new DevExpress.XtraEditors.SimpleButton();
            this.kitapyonetimi_btn = new DevExpress.XtraEditors.SimpleButton();
            this.odunc_iade_btn = new DevExpress.XtraEditors.SimpleButton();
            this.uyeyonetim_btn = new DevExpress.XtraEditors.SimpleButton();
            this.stok_raporlama_btn = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // cikis_btn
            // 
            this.cikis_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cikis_btn.ImageOptions.Image")));
            this.cikis_btn.Location = new System.Drawing.Point(777, 175);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(119, 56);
            this.cikis_btn.TabIndex = 5;
            this.cikis_btn.Text = "Çıkış Yap";
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click_1);
            // 
            // kitapyonetimi_btn
            // 
            this.kitapyonetimi_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kitapyonetimi_btn.ImageOptions.Image")));
            this.kitapyonetimi_btn.Location = new System.Drawing.Point(229, 12);
            this.kitapyonetimi_btn.Name = "kitapyonetimi_btn";
            this.kitapyonetimi_btn.Size = new System.Drawing.Size(200, 146);
            this.kitapyonetimi_btn.TabIndex = 6;
            this.kitapyonetimi_btn.Text = "Kitap Yönetimi";
            this.kitapyonetimi_btn.Click += new System.EventHandler(this.kitapyonetimi_btn_Click);
            // 
            // odunc_iade_btn
            // 
            this.odunc_iade_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("odunc_iade_btn.ImageOptions.Image")));
            this.odunc_iade_btn.Location = new System.Drawing.Point(12, 12);
            this.odunc_iade_btn.Name = "odunc_iade_btn";
            this.odunc_iade_btn.Size = new System.Drawing.Size(191, 146);
            this.odunc_iade_btn.TabIndex = 7;
            this.odunc_iade_btn.Text = "Ödünç Ve İade";
            this.odunc_iade_btn.Click += new System.EventHandler(this.odunc_iade_btn_Click_1);
            // 
            // uyeyonetim_btn
            // 
            this.uyeyonetim_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("uyeyonetim_btn.ImageOptions.Image")));
            this.uyeyonetim_btn.Location = new System.Drawing.Point(465, 12);
            this.uyeyonetim_btn.Name = "uyeyonetim_btn";
            this.uyeyonetim_btn.Size = new System.Drawing.Size(200, 146);
            this.uyeyonetim_btn.TabIndex = 8;
            this.uyeyonetim_btn.Text = "Üye Yönetimi";
            this.uyeyonetim_btn.Click += new System.EventHandler(this.uyeyonetim_btn_Click);
            // 
            // stok_raporlama_btn
            // 
            this.stok_raporlama_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("stok_raporlama_btn.ImageOptions.Image")));
            this.stok_raporlama_btn.Location = new System.Drawing.Point(693, 12);
            this.stok_raporlama_btn.Name = "stok_raporlama_btn";
            this.stok_raporlama_btn.Size = new System.Drawing.Size(203, 146);
            this.stok_raporlama_btn.TabIndex = 9;
            this.stok_raporlama_btn.Text = "Stok Ve Raporlama";
            this.stok_raporlama_btn.Click += new System.EventHandler(this.stok_raporlama_btn_Click_1);
            // 
            // personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(940, 251);
            this.Controls.Add(this.stok_raporlama_btn);
            this.Controls.Add(this.uyeyonetim_btn);
            this.Controls.Add(this.odunc_iade_btn);
            this.Controls.Add(this.kitapyonetimi_btn);
            this.Controls.Add(this.cikis_btn);
            this.Name = "personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "personel";
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton cikis_btn;
        private DevExpress.XtraEditors.SimpleButton kitapyonetimi_btn;
        private DevExpress.XtraEditors.SimpleButton odunc_iade_btn;
        private DevExpress.XtraEditors.SimpleButton uyeyonetim_btn;
        private DevExpress.XtraEditors.SimpleButton stok_raporlama_btn;
    }
}