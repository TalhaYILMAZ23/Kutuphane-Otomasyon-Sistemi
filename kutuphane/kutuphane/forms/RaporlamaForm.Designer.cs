namespace Kutuphane
{
    partial class RaporlamaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporlamaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.populer_kitaplar_datagrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.aktif_uyeler_datagrid = new System.Windows.Forms.DataGridView();
            this.btn_export_populer = new DevExpress.XtraEditors.SimpleButton();
            this.btn_export_aktif = new DevExpress.XtraEditors.SimpleButton();
            this.stok_datagrid = new System.Windows.Forms.DataGridView();
            this.tumkitap_btn = new DevExpress.XtraEditors.SimpleButton();
            this.kritik_btn = new DevExpress.XtraEditors.SimpleButton();
            this.stok_pdf_btn = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.populer_kitaplar_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktif_uyeler_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popüler Kitaplar";
            // 
            // populer_kitaplar_datagrid
            // 
            this.populer_kitaplar_datagrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.populer_kitaplar_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.populer_kitaplar_datagrid.Location = new System.Drawing.Point(39, 106);
            this.populer_kitaplar_datagrid.Name = "populer_kitaplar_datagrid";
            this.populer_kitaplar_datagrid.RowHeadersWidth = 51;
            this.populer_kitaplar_datagrid.RowTemplate.Height = 24;
            this.populer_kitaplar_datagrid.Size = new System.Drawing.Size(356, 194);
            this.populer_kitaplar_datagrid.TabIndex = 1;
            this.populer_kitaplar_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.populer_kitaplar_datagrid_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "En Aktif Üyeler";
            // 
            // aktif_uyeler_datagrid
            // 
            this.aktif_uyeler_datagrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.aktif_uyeler_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aktif_uyeler_datagrid.Location = new System.Drawing.Point(468, 106);
            this.aktif_uyeler_datagrid.Name = "aktif_uyeler_datagrid";
            this.aktif_uyeler_datagrid.RowHeadersWidth = 51;
            this.aktif_uyeler_datagrid.RowTemplate.Height = 24;
            this.aktif_uyeler_datagrid.Size = new System.Drawing.Size(347, 194);
            this.aktif_uyeler_datagrid.TabIndex = 1;
            // 
            // btn_export_populer
            // 
            this.btn_export_populer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_export_populer.ImageOptions.Image")));
            this.btn_export_populer.Location = new System.Drawing.Point(142, 314);
            this.btn_export_populer.Name = "btn_export_populer";
            this.btn_export_populer.Size = new System.Drawing.Size(159, 40);
            this.btn_export_populer.TabIndex = 4;
            this.btn_export_populer.Text = "PDF\'e Aktar";
            this.btn_export_populer.Click += new System.EventHandler(this.btn_export_populer_Click_1);
            // 
            // btn_export_aktif
            // 
            this.btn_export_aktif.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_export_aktif.ImageOptions.Image")));
            this.btn_export_aktif.Location = new System.Drawing.Point(568, 315);
            this.btn_export_aktif.Name = "btn_export_aktif";
            this.btn_export_aktif.Size = new System.Drawing.Size(162, 39);
            this.btn_export_aktif.TabIndex = 5;
            this.btn_export_aktif.Text = "PDF\'e Aktar";
            this.btn_export_aktif.Click += new System.EventHandler(this.btn_export_aktif_Click_1);
            // 
            // stok_datagrid
            // 
            this.stok_datagrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.stok_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stok_datagrid.Location = new System.Drawing.Point(864, 107);
            this.stok_datagrid.Name = "stok_datagrid";
            this.stok_datagrid.RowHeadersWidth = 51;
            this.stok_datagrid.RowTemplate.Height = 24;
            this.stok_datagrid.Size = new System.Drawing.Size(375, 192);
            this.stok_datagrid.TabIndex = 6;
            // 
            // tumkitap_btn
            // 
            this.tumkitap_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tumkitap_btn.ImageOptions.Image")));
            this.tumkitap_btn.Location = new System.Drawing.Point(864, 322);
            this.tumkitap_btn.Name = "tumkitap_btn";
            this.tumkitap_btn.Size = new System.Drawing.Size(166, 44);
            this.tumkitap_btn.TabIndex = 7;
            this.tumkitap_btn.Text = "Tüm Kitaplar";
            this.tumkitap_btn.Click += new System.EventHandler(this.tumkitap_btn_Click);
            // 
            // kritik_btn
            // 
            this.kritik_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.kritik_btn.Location = new System.Drawing.Point(1036, 323);
            this.kritik_btn.Name = "kritik_btn";
            this.kritik_btn.Size = new System.Drawing.Size(181, 42);
            this.kritik_btn.TabIndex = 8;
            this.kritik_btn.Text = "Kritik Stok Kontrol";
            this.kritik_btn.Click += new System.EventHandler(this.kritik_btn_Click);
            // 
            // stok_pdf_btn
            // 
            this.stok_pdf_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("stok_pdf.ImageOptions.Image")));
            this.stok_pdf_btn.Location = new System.Drawing.Point(1036, 383);
            this.stok_pdf_btn.Name = "stok_pdf_btn";
            this.stok_pdf_btn.Size = new System.Drawing.Size(181, 40);
            this.stok_pdf_btn.TabIndex = 9;
            this.stok_pdf_btn.Text = "PDF\'e Aktar";
            this.stok_pdf_btn.Click += new System.EventHandler(this.stok_pdf_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(861, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stok Kontrolü";
            // 
            // RaporlamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1323, 447);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stok_pdf_btn);
            this.Controls.Add(this.kritik_btn);
            this.Controls.Add(this.tumkitap_btn);
            this.Controls.Add(this.stok_datagrid);
            this.Controls.Add(this.btn_export_aktif);
            this.Controls.Add(this.btn_export_populer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aktif_uyeler_datagrid);
            this.Controls.Add(this.populer_kitaplar_datagrid);
            this.Controls.Add(this.label1);
            this.Name = "RaporlamaForm";
            this.Text = "RaporlamaForm";
            this.Load += new System.EventHandler(this.RaporlamaForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.populer_kitaplar_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktif_uyeler_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView populer_kitaplar_datagrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView aktif_uyeler_datagrid;
        private DevExpress.XtraEditors.SimpleButton btn_export_populer;
        private DevExpress.XtraEditors.SimpleButton btn_export_aktif;
        private System.Windows.Forms.DataGridView stok_datagrid;
        private DevExpress.XtraEditors.SimpleButton tumkitap_btn;
        private DevExpress.XtraEditors.SimpleButton kritik_btn;
        private DevExpress.XtraEditors.SimpleButton stok_pdf_btn;
        private System.Windows.Forms.Label label3;
    }
}