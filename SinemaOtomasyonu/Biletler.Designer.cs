namespace SinemaOtomasyonu
{
    partial class Biletler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biletler));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.biletSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletİadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletİşlemGeçmişleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.biletlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biletlerDataSet = new SinemaOtomasyonu.BiletlerDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfilm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkoltukno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.biletlerTableAdapter = new SinemaOtomasyonu.BiletlerDataSetTableAdapters.BiletlerTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.lblArananalan = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.ComboBox();
            this.salonlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salonlarDataSet = new SinemaOtomasyonu.SalonlarDataSet();
            this.textBox2 = new System.Windows.Forms.ComboBox();
            this.filmlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmlerDataSet = new SinemaOtomasyonu.FilmlerDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnara = new System.Windows.Forms.Button();
            this.filmlerTableAdapter = new SinemaOtomasyonu.FilmlerDataSetTableAdapters.FilmlerTableAdapter();
            this.salonlarTableAdapter = new SinemaOtomasyonu.SalonlarDataSetTableAdapters.SalonlarTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletlerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salonlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonlarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biletSatışToolStripMenuItem,
            this.biletİadeToolStripMenuItem,
            this.biletDeğiştirToolStripMenuItem,
            this.biletİşlemGeçmişleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // biletSatışToolStripMenuItem
            // 
            this.biletSatışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("biletSatışToolStripMenuItem.Image")));
            this.biletSatışToolStripMenuItem.Name = "biletSatışToolStripMenuItem";
            this.biletSatışToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.biletSatışToolStripMenuItem.Text = "Bilet Satış";
            this.biletSatışToolStripMenuItem.Click += new System.EventHandler(this.biletSatışToolStripMenuItem_Click);
            // 
            // biletİadeToolStripMenuItem
            // 
            this.biletİadeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("biletİadeToolStripMenuItem.Image")));
            this.biletİadeToolStripMenuItem.Name = "biletİadeToolStripMenuItem";
            this.biletİadeToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.biletİadeToolStripMenuItem.Text = "Bilet İade";
            this.biletİadeToolStripMenuItem.Click += new System.EventHandler(this.biletİadeToolStripMenuItem_Click);
            // 
            // biletDeğiştirToolStripMenuItem
            // 
            this.biletDeğiştirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("biletDeğiştirToolStripMenuItem.Image")));
            this.biletDeğiştirToolStripMenuItem.Name = "biletDeğiştirToolStripMenuItem";
            this.biletDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.biletDeğiştirToolStripMenuItem.Text = "Bilet Değiştir";
            this.biletDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.biletDeğiştirToolStripMenuItem_Click);
            // 
            // biletİşlemGeçmişleriToolStripMenuItem
            // 
            this.biletİşlemGeçmişleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("biletİşlemGeçmişleriToolStripMenuItem.Image")));
            this.biletİşlemGeçmişleriToolStripMenuItem.Name = "biletİşlemGeçmişleriToolStripMenuItem";
            this.biletİşlemGeçmişleriToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.biletİşlemGeçmişleriToolStripMenuItem.Text = "Bilet İşlem Geçmişleri";
            this.biletİşlemGeçmişleriToolStripMenuItem.Click += new System.EventHandler(this.biletİşlemGeçmişleriToolStripMenuItem_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.biletlerBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(804, 499);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // biletlerBindingSource
            // 
            this.biletlerBindingSource.DataMember = "Biletler";
            this.biletlerBindingSource.DataSource = this.biletlerDataSet;
            // 
            // biletlerDataSet
            // 
            this.biletlerDataSet.DataSetName = "BiletlerDataSet";
            this.biletlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colfilm,
            this.colseans,
            this.colsalon,
            this.colkoltukno,
            this.colad,
            this.colmail});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colfilm
            // 
            this.colfilm.Caption = "Film";
            this.colfilm.FieldName = "film";
            this.colfilm.Name = "colfilm";
            this.colfilm.Visible = true;
            this.colfilm.VisibleIndex = 3;
            // 
            // colseans
            // 
            this.colseans.Caption = "Seans";
            this.colseans.FieldName = "seans";
            this.colseans.Name = "colseans";
            this.colseans.Visible = true;
            this.colseans.VisibleIndex = 4;
            // 
            // colsalon
            // 
            this.colsalon.Caption = "Salon";
            this.colsalon.FieldName = "salon";
            this.colsalon.Name = "colsalon";
            this.colsalon.Visible = true;
            this.colsalon.VisibleIndex = 5;
            // 
            // colkoltukno
            // 
            this.colkoltukno.Caption = "Koltuk No";
            this.colkoltukno.FieldName = "koltukno";
            this.colkoltukno.Name = "colkoltukno";
            this.colkoltukno.Visible = true;
            this.colkoltukno.VisibleIndex = 6;
            // 
            // colad
            // 
            this.colad.Caption = "Ad";
            this.colad.FieldName = "ad";
            this.colad.Name = "colad";
            this.colad.Visible = true;
            this.colad.VisibleIndex = 1;
            // 
            // colmail
            // 
            this.colmail.Caption = "Mail Adresi";
            this.colmail.FieldName = "mail";
            this.colmail.Name = "colmail";
            this.colmail.Visible = true;
            this.colmail.VisibleIndex = 2;
            // 
            // biletlerTableAdapter
            // 
            this.biletlerTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtAranan);
            this.groupBox2.Controls.Add(this.lblArananalan);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbAramaTuru);
            this.groupBox2.Location = new System.Drawing.Point(816, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 249);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hızlı Arama";
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(2, 213);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(200, 26);
            this.txtAranan.TabIndex = 9;
            this.txtAranan.TextChanged += new System.EventHandler(this.txtAranan_TextChanged);
            // 
            // lblArananalan
            // 
            this.lblArananalan.AutoSize = true;
            this.lblArananalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblArananalan.Location = new System.Drawing.Point(2, 190);
            this.lblArananalan.Name = "lblArananalan";
            this.lblArananalan.Size = new System.Drawing.Size(68, 20);
            this.lblArananalan.TabIndex = 8;
            this.lblArananalan.Text = "Üye Adı:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(6, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 105);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alan Seçimi";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Film Adı";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.rad2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Üye Adı";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.rad1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Arama Türü";
            // 
            // cmbAramaTuru
            // 
            this.cmbAramaTuru.FormattingEnabled = true;
            this.cmbAramaTuru.Items.AddRange(new object[] {
            "İle Başlayan",
            "İle Biten",
            "İçeren"});
            this.cmbAramaTuru.Location = new System.Drawing.Point(6, 48);
            this.cmbAramaTuru.Name = "cmbAramaTuru";
            this.cmbAramaTuru.Size = new System.Drawing.Size(198, 28);
            this.cmbAramaTuru.TabIndex = 5;
            this.cmbAramaTuru.Text = "İle Başlayan";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btnara);
            this.groupBox1.Location = new System.Drawing.Point(816, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 255);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birebir Arama";
            // 
            // textBox3
            // 
            this.textBox3.DataSource = this.salonlarBindingSource;
            this.textBox3.DisplayMember = "ad";
            this.textBox3.Enabled = false;
            this.textBox3.FormattingEnabled = true;
            this.textBox3.Location = new System.Drawing.Point(6, 180);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 28);
            this.textBox3.TabIndex = 13;
            this.textBox3.ValueMember = "id";
            // 
            // salonlarBindingSource
            // 
            this.salonlarBindingSource.DataMember = "Salonlar";
            this.salonlarBindingSource.DataSource = this.salonlarDataSet;
            // 
            // salonlarDataSet
            // 
            this.salonlarDataSet.DataSetName = "SalonlarDataSet";
            this.salonlarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.DataSource = this.filmlerBindingSource;
            this.textBox2.DisplayMember = "ad";
            this.textBox2.Enabled = false;
            this.textBox2.FormattingEnabled = true;
            this.textBox2.Location = new System.Drawing.Point(6, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 28);
            this.textBox2.TabIndex = 12;
            this.textBox2.ValueMember = "id";
            // 
            // filmlerBindingSource
            // 
            this.filmlerBindingSource.DataMember = "Filmler";
            this.filmlerBindingSource.DataSource = this.filmlerDataSet;
            // 
            // filmlerDataSet
            // 
            this.filmlerDataSet.DataSetName = "FilmlerDataSet";
            this.filmlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(6, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 11;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox3.Location = new System.Drawing.Point(9, 153);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(65, 22);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Salon";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox2.Location = new System.Drawing.Point(9, 91);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(55, 22);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Film";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox1.Location = new System.Drawing.Point(9, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 22);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Üye Ad";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnara
            // 
            this.btnara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnara.Location = new System.Drawing.Point(6, 214);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(201, 35);
            this.btnara.TabIndex = 7;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // filmlerTableAdapter
            // 
            this.filmlerTableAdapter.ClearBeforeFill = true;
            // 
            // salonlarTableAdapter
            // 
            this.salonlarTableAdapter.ClearBeforeFill = true;
            // 
            // Biletler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Biletler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bilet Satış";
            this.Load += new System.EventHandler(this.BiletSatis_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletlerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salonlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonlarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem biletSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletİadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletİşlemGeçmişleriToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BiletlerDataSet biletlerDataSet;
        private System.Windows.Forms.BindingSource biletlerBindingSource;
        private BiletlerDataSetTableAdapters.BiletlerTableAdapter biletlerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colfilm;
        private DevExpress.XtraGrid.Columns.GridColumn colseans;
        private DevExpress.XtraGrid.Columns.GridColumn colsalon;
        private DevExpress.XtraGrid.Columns.GridColumn colkoltukno;
        private DevExpress.XtraGrid.Columns.GridColumn colad;
        private DevExpress.XtraGrid.Columns.GridColumn colmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Label lblArananalan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.ComboBox textBox3;
        private System.Windows.Forms.ComboBox textBox2;
        private FilmlerDataSet filmlerDataSet;
        private System.Windows.Forms.BindingSource filmlerBindingSource;
        private FilmlerDataSetTableAdapters.FilmlerTableAdapter filmlerTableAdapter;
        private SalonlarDataSet salonlarDataSet;
        private System.Windows.Forms.BindingSource salonlarBindingSource;
        private SalonlarDataSetTableAdapters.SalonlarTableAdapter salonlarTableAdapter;
    }
}