namespace Kutuphane
{
    partial class uye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uye));
            this.kitap_arama_txt = new System.Windows.Forms.TextBox();
            this.kitap_ara_lbl = new System.Windows.Forms.Label();
            this.odunkitap_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kitaparama_ara_btn = new DevExpress.XtraEditors.SimpleButton();
            this.odunckitaplist_datagridd = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.kitaparama_datagridd = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.populer_kitaplar_listboxx = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.odunckitaplist_datagridd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaparama_datagridd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populer_kitaplar_listboxx)).BeginInit();
            this.SuspendLayout();
            // 
            // kitap_arama_txt
            // 
            this.kitap_arama_txt.BackColor = System.Drawing.SystemColors.Info;
            this.kitap_arama_txt.Location = new System.Drawing.Point(901, 570);
            this.kitap_arama_txt.Name = "kitap_arama_txt";
            this.kitap_arama_txt.Size = new System.Drawing.Size(205, 22);
            this.kitap_arama_txt.TabIndex = 0;
            // 
            // kitap_ara_lbl
            // 
            this.kitap_ara_lbl.AutoSize = true;
            this.kitap_ara_lbl.Location = new System.Drawing.Point(829, 573);
            this.kitap_ara_lbl.Name = "kitap_ara_lbl";
            this.kitap_ara_lbl.Size = new System.Drawing.Size(66, 16);
            this.kitap_ara_lbl.TabIndex = 3;
            this.kitap_ara_lbl.Text = "Kitap Adı :";
            // 
            // odunkitap_lbl
            // 
            this.odunkitap_lbl.AutoSize = true;
            this.odunkitap_lbl.Location = new System.Drawing.Point(13, 22);
            this.odunkitap_lbl.Name = "odunkitap_lbl";
            this.odunkitap_lbl.Size = new System.Drawing.Size(146, 16);
            this.odunkitap_lbl.TabIndex = 4;
            this.odunkitap_lbl.Text = "Ödünç Aldığınız kitaplar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Popüler Kitaplar";
            // 
            // kitaparama_ara_btn
            // 
            this.kitaparama_ara_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kitaparama_ara_btn.ImageOptions.Image")));
            this.kitaparama_ara_btn.Location = new System.Drawing.Point(998, 611);
            this.kitaparama_ara_btn.Name = "kitaparama_ara_btn";
            this.kitaparama_ara_btn.Size = new System.Drawing.Size(108, 37);
            this.kitaparama_ara_btn.TabIndex = 7;
            this.kitaparama_ara_btn.Text = "Ara";
            this.kitaparama_ara_btn.Click += new System.EventHandler(this.kitaparama_ara_btn_Click_1);
            // 
            // odunckitaplist_datagridd
            // 
            this.odunckitaplist_datagridd.Location = new System.Drawing.Point(12, 56);
            this.odunckitaplist_datagridd.MainView = this.gridView1;
            this.odunckitaplist_datagridd.Name = "odunckitaplist_datagridd";
            this.odunckitaplist_datagridd.Size = new System.Drawing.Size(572, 497);
            this.odunckitaplist_datagridd.TabIndex = 8;
            this.odunckitaplist_datagridd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.odunckitaplist_datagridd;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // kitaparama_datagridd
            // 
            this.kitaparama_datagridd.Location = new System.Drawing.Point(652, 258);
            this.kitaparama_datagridd.MainView = this.gridView2;
            this.kitaparama_datagridd.Name = "kitaparama_datagridd";
            this.kitaparama_datagridd.Size = new System.Drawing.Size(454, 295);
            this.kitaparama_datagridd.TabIndex = 9;
            this.kitaparama_datagridd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.kitaparama_datagridd;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // populer_kitaplar_listboxx
            // 
            this.populer_kitaplar_listboxx.Location = new System.Drawing.Point(652, 56);
            this.populer_kitaplar_listboxx.Name = "populer_kitaplar_listboxx";
            this.populer_kitaplar_listboxx.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.populer_kitaplar_listboxx.Size = new System.Drawing.Size(454, 196);
            this.populer_kitaplar_listboxx.TabIndex = 10;
            // 
            // uye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1169, 673);
            this.Controls.Add(this.populer_kitaplar_listboxx);
            this.Controls.Add(this.kitaparama_datagridd);
            this.Controls.Add(this.odunckitaplist_datagridd);
            this.Controls.Add(this.kitaparama_ara_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odunkitap_lbl);
            this.Controls.Add(this.kitap_ara_lbl);
            this.Controls.Add(this.kitap_arama_txt);
            this.Name = "uye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uye";
            this.Load += new System.EventHandler(this.uye_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.odunckitaplist_datagridd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaparama_datagridd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populer_kitaplar_listboxx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kitap_arama_txt;
        private System.Windows.Forms.Label kitap_ara_lbl;
        private System.Windows.Forms.Label odunkitap_lbl;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton kitaparama_ara_btn;
        private DevExpress.XtraGrid.GridControl odunckitaplist_datagridd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl kitaparama_datagridd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.ListBoxControl populer_kitaplar_listboxx;
    }
}