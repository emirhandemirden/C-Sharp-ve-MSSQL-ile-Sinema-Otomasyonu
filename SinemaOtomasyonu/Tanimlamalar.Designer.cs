namespace SinemaOtomasyonu
{
    partial class Tanimlamalar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tanimlamalar));
            this.lst_filmturleri = new System.Windows.Forms.ListBox();
            this.filmTurleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTurleriDataSet = new SinemaOtomasyonu.FilmTurleriDataSet();
            this.filmTurleriTableAdapter = new SinemaOtomasyonu.FilmTurleriDataSetTableAdapters.FilmTurleriTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_filmture = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_filmturs = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_filmturg = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_biletturleri = new System.Windows.Forms.ListBox();
            this.biletTurleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biletTurleriDataSet = new SinemaOtomasyonu.BiletTurleriDataSet();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_biletture = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_biletturs = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_biletturg = new System.Windows.Forms.ToolStripButton();
            this.biletTurleriTableAdapter = new SinemaOtomasyonu.BiletTurleriDataSetTableAdapters.BiletTurleriTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lst_salonlar = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_salone = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_salons = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_salong = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.filmTurleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTurleriDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biletTurleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletTurleriDataSet)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_filmturleri
            // 
            this.lst_filmturleri.DataSource = this.filmTurleriBindingSource;
            this.lst_filmturleri.DisplayMember = "tur";
            this.lst_filmturleri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lst_filmturleri.FormattingEnabled = true;
            this.lst_filmturleri.ItemHeight = 20;
            this.lst_filmturleri.Location = new System.Drawing.Point(4, 55);
            this.lst_filmturleri.Margin = new System.Windows.Forms.Padding(4);
            this.lst_filmturleri.Name = "lst_filmturleri";
            this.lst_filmturleri.Size = new System.Drawing.Size(256, 404);
            this.lst_filmturleri.TabIndex = 0;
            this.lst_filmturleri.ValueMember = "id";
            // 
            // filmTurleriBindingSource
            // 
            this.filmTurleriBindingSource.DataMember = "FilmTurleri";
            this.filmTurleriBindingSource.DataSource = this.filmTurleriDataSet;
            // 
            // filmTurleriDataSet
            // 
            this.filmTurleriDataSet.DataSetName = "FilmTurleriDataSet";
            this.filmTurleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmTurleriTableAdapter
            // 
            this.filmTurleriTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.lst_filmturleri);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(264, 463);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Türleri";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_filmture,
            this.tsbtn_filmturs,
            this.tsbtn_filmturg});
            this.toolStrip1.Location = new System.Drawing.Point(4, 23);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(256, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_filmture
            // 
            this.tsbtn_filmture.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_filmture.Image")));
            this.tsbtn_filmture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_filmture.Name = "tsbtn_filmture";
            this.tsbtn_filmture.Size = new System.Drawing.Size(48, 22);
            this.tsbtn_filmture.Text = "Ekle";
            this.tsbtn_filmture.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbtn_filmturs
            // 
            this.tsbtn_filmturs.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_filmturs.Image")));
            this.tsbtn_filmturs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_filmturs.Name = "tsbtn_filmturs";
            this.tsbtn_filmturs.Size = new System.Drawing.Size(39, 22);
            this.tsbtn_filmturs.Text = "Sil";
            this.tsbtn_filmturs.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsbtn_filmturg
            // 
            this.tsbtn_filmturg.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_filmturg.Image")));
            this.tsbtn_filmturg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_filmturg.Name = "tsbtn_filmturg";
            this.tsbtn_filmturg.Size = new System.Drawing.Size(73, 22);
            this.tsbtn_filmturg.Text = "Güncelle";
            this.tsbtn_filmturg.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox2.Controls.Add(this.lst_biletturleri);
            this.groupBox2.Controls.Add(this.toolStrip2);
            this.groupBox2.Location = new System.Drawing.Point(269, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(264, 463);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilet Türleri";
            // 
            // lst_biletturleri
            // 
            this.lst_biletturleri.DataSource = this.biletTurleriBindingSource;
            this.lst_biletturleri.DisplayMember = "tur";
            this.lst_biletturleri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lst_biletturleri.FormattingEnabled = true;
            this.lst_biletturleri.ItemHeight = 20;
            this.lst_biletturleri.Location = new System.Drawing.Point(4, 55);
            this.lst_biletturleri.Margin = new System.Windows.Forms.Padding(4);
            this.lst_biletturleri.Name = "lst_biletturleri";
            this.lst_biletturleri.Size = new System.Drawing.Size(256, 404);
            this.lst_biletturleri.TabIndex = 4;
            this.lst_biletturleri.ValueMember = "id";
            // 
            // biletTurleriBindingSource
            // 
            this.biletTurleriBindingSource.DataMember = "BiletTurleri";
            this.biletTurleriBindingSource.DataSource = this.biletTurleriDataSet;
            // 
            // biletTurleriDataSet
            // 
            this.biletTurleriDataSet.DataSetName = "BiletTurleriDataSet";
            this.biletTurleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_biletture,
            this.tsbtn_biletturs,
            this.tsbtn_biletturg});
            this.toolStrip2.Location = new System.Drawing.Point(4, 23);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(256, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbtn_biletture
            // 
            this.tsbtn_biletture.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_biletture.Image")));
            this.tsbtn_biletture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_biletture.Name = "tsbtn_biletture";
            this.tsbtn_biletture.Size = new System.Drawing.Size(48, 22);
            this.tsbtn_biletture.Text = "Ekle";
            this.tsbtn_biletture.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tsbtn_biletturs
            // 
            this.tsbtn_biletturs.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_biletturs.Image")));
            this.tsbtn_biletturs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_biletturs.Name = "tsbtn_biletturs";
            this.tsbtn_biletturs.Size = new System.Drawing.Size(39, 22);
            this.tsbtn_biletturs.Text = "Sil";
            this.tsbtn_biletturs.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // tsbtn_biletturg
            // 
            this.tsbtn_biletturg.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_biletturg.Image")));
            this.tsbtn_biletturg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_biletturg.Name = "tsbtn_biletturg";
            this.tsbtn_biletturg.Size = new System.Drawing.Size(73, 22);
            this.tsbtn_biletturg.Text = "Güncelle";
            this.tsbtn_biletturg.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // biletTurleriTableAdapter
            // 
            this.biletTurleriTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox3.Controls.Add(this.lst_salonlar);
            this.groupBox3.Controls.Add(this.toolStrip3);
            this.groupBox3.Location = new System.Drawing.Point(536, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(264, 463);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salonlar";
            // 
            // lst_salonlar
            // 
            this.lst_salonlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.lst_salonlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lst_salonlar.FullRowSelect = true;
            this.lst_salonlar.HideSelection = false;
            this.lst_salonlar.Location = new System.Drawing.Point(4, 55);
            this.lst_salonlar.Name = "lst_salonlar";
            this.lst_salonlar.Size = new System.Drawing.Size(256, 404);
            this.lst_salonlar.TabIndex = 4;
            this.lst_salonlar.UseCompatibleStateImageBehavior = false;
            this.lst_salonlar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kişi Sayısı";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_salone,
            this.tsbtn_salons,
            this.tsbtn_salong});
            this.toolStrip3.Location = new System.Drawing.Point(4, 23);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(256, 25);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tsbtn_salone
            // 
            this.tsbtn_salone.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_salone.Image")));
            this.tsbtn_salone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_salone.Name = "tsbtn_salone";
            this.tsbtn_salone.Size = new System.Drawing.Size(48, 22);
            this.tsbtn_salone.Text = "Ekle";
            this.tsbtn_salone.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // tsbtn_salons
            // 
            this.tsbtn_salons.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_salons.Image")));
            this.tsbtn_salons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_salons.Name = "tsbtn_salons";
            this.tsbtn_salons.Size = new System.Drawing.Size(39, 22);
            this.tsbtn_salons.Text = "Sil";
            this.tsbtn_salons.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // tsbtn_salong
            // 
            this.tsbtn_salong.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_salong.Image")));
            this.tsbtn_salong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_salong.Name = "tsbtn_salong";
            this.tsbtn_salong.Size = new System.Drawing.Size(73, 22);
            this.tsbtn_salong.Text = "Güncelle";
            this.tsbtn_salong.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // Tanimlamalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 463);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Tanimlamalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tanımlamalar";
            this.Load += new System.EventHandler(this.Tanimlamalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmTurleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTurleriDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biletTurleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletTurleriDataSet)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_filmturleri;
        private FilmTurleriDataSet filmTurleriDataSet;
        private System.Windows.Forms.BindingSource filmTurleriBindingSource;
        private FilmTurleriDataSetTableAdapters.FilmTurleriTableAdapter filmTurleriTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private BiletTurleriDataSet biletTurleriDataSet;
        private System.Windows.Forms.BindingSource biletTurleriBindingSource;
        private BiletTurleriDataSetTableAdapters.BiletTurleriTableAdapter biletTurleriTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtn_filmture;
        private System.Windows.Forms.ToolStripButton tsbtn_filmturs;
        private System.Windows.Forms.ToolStripButton tsbtn_filmturg;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbtn_biletture;
        private System.Windows.Forms.ToolStripButton tsbtn_biletturs;
        private System.Windows.Forms.ToolStripButton tsbtn_biletturg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton tsbtn_salone;
        private System.Windows.Forms.ToolStripButton tsbtn_salons;
        private System.Windows.Forms.ToolStripButton tsbtn_salong;
        private System.Windows.Forms.ListBox lst_biletturleri;
        private System.Windows.Forms.ListView lst_salonlar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}