namespace Kutuphane
{
    partial class OduncIadeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OduncIadeForm));
            this.uye_secin_cb = new System.Windows.Forms.ComboBox();
            this.kitap_arama_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iade_ver_btn = new DevExpress.XtraEditors.SimpleButton();
            this.odunc_ver_btn = new DevExpress.XtraEditors.SimpleButton();
            this.odunc_kitaplari_getir_btn = new DevExpress.XtraEditors.SimpleButton();
            this.odunc_kitaplar_datagridd = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.odunc_kitaplar_datagridd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uye_secin_cb
            // 
            this.uye_secin_cb.FormattingEnabled = true;
            this.uye_secin_cb.Location = new System.Drawing.Point(34, 48);
            this.uye_secin_cb.Name = "uye_secin_cb";
            this.uye_secin_cb.Size = new System.Drawing.Size(267, 24);
            this.uye_secin_cb.TabIndex = 0;
            this.uye_secin_cb.TextChanged += new System.EventHandler(this.uye_secin_cb_TextChanged);
            // 
            // kitap_arama_cb
            // 
            this.kitap_arama_cb.FormattingEnabled = true;
            this.kitap_arama_cb.Location = new System.Drawing.Point(34, 127);
            this.kitap_arama_cb.Name = "kitap_arama_cb";
            this.kitap_arama_cb.Size = new System.Drawing.Size(267, 24);
            this.kitap_arama_cb.TabIndex = 1;
            this.kitap_arama_cb.TextChanged += new System.EventHandler(this.kitap_arama_cb_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Seç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kitap Seç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ödünç Kitaplar Listesi";
            // 
            // iade_ver_btn
            // 
            this.iade_ver_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("iade_ver_btn.ImageOptions.Image")));
            this.iade_ver_btn.Location = new System.Drawing.Point(37, 170);
            this.iade_ver_btn.Name = "iade_ver_btn";
            this.iade_ver_btn.Size = new System.Drawing.Size(121, 48);
            this.iade_ver_btn.TabIndex = 5;
            this.iade_ver_btn.Text = "İade Al";
            this.iade_ver_btn.Click += new System.EventHandler(this.iade_ver_btn_Click);
            // 
            // odunc_ver_btn
            // 
            this.odunc_ver_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("odunc_ver_btn.ImageOptions.Image")));
            this.odunc_ver_btn.Location = new System.Drawing.Point(184, 170);
            this.odunc_ver_btn.Name = "odunc_ver_btn";
            this.odunc_ver_btn.Size = new System.Drawing.Size(117, 48);
            this.odunc_ver_btn.TabIndex = 6;
            this.odunc_ver_btn.Text = "Ödünç Ver";
            this.odunc_ver_btn.Click += new System.EventHandler(this.odunc_ver_btn_Click_1);
            // 
            // odunc_kitaplari_getir_btn
            // 
            this.odunc_kitaplari_getir_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("odunc_kitaplari_getir_btn.ImageOptions.Image")));
            this.odunc_kitaplari_getir_btn.Location = new System.Drawing.Point(353, 252);
            this.odunc_kitaplari_getir_btn.Name = "odunc_kitaplari_getir_btn";
            this.odunc_kitaplari_getir_btn.Size = new System.Drawing.Size(132, 47);
            this.odunc_kitaplari_getir_btn.TabIndex = 7;
            this.odunc_kitaplari_getir_btn.Text = "Getir";
            this.odunc_kitaplari_getir_btn.Click += new System.EventHandler(this.odunc_kitaplari_getir_btn_Click_1);
            // 
            // odunc_kitaplar_datagridd
            // 
            this.odunc_kitaplar_datagridd.Location = new System.Drawing.Point(353, 42);
            this.odunc_kitaplar_datagridd.MainView = this.gridView1;
            this.odunc_kitaplar_datagridd.Name = "odunc_kitaplar_datagridd";
            this.odunc_kitaplar_datagridd.Size = new System.Drawing.Size(646, 204);
            this.odunc_kitaplar_datagridd.TabIndex = 8;
            this.odunc_kitaplar_datagridd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.odunc_kitaplar_datagridd;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // OduncIadeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1055, 371);
            this.Controls.Add(this.odunc_kitaplar_datagridd);
            this.Controls.Add(this.odunc_kitaplari_getir_btn);
            this.Controls.Add(this.odunc_ver_btn);
            this.Controls.Add(this.iade_ver_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kitap_arama_cb);
            this.Controls.Add(this.uye_secin_cb);
            this.Name = "OduncIadeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OduncIade";
            this.Load += new System.EventHandler(this.OduncIade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.odunc_kitaplar_datagridd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uye_secin_cb;
        private System.Windows.Forms.ComboBox kitap_arama_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton iade_ver_btn;
        private DevExpress.XtraEditors.SimpleButton odunc_ver_btn;
        private DevExpress.XtraEditors.SimpleButton odunc_kitaplari_getir_btn;
        private DevExpress.XtraGrid.GridControl odunc_kitaplar_datagridd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}