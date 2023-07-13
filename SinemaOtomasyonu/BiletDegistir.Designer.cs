namespace SinemaOtomasyonu
{
    partial class BiletDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiletDegistir));
            this.lbl_biletid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbx_koltukno = new System.Windows.Forms.ComboBox();
            this.txt_salon = new System.Windows.Forms.TextBox();
            this.cmbx_seans = new System.Windows.Forms.ComboBox();
            this.cmbx_film = new System.Windows.Forms.ComboBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.filmlerDataSet = new SinemaOtomasyonu.FilmlerDataSet();
            this.filmlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmlerTableAdapter = new SinemaOtomasyonu.FilmlerDataSetTableAdapters.FilmlerTableAdapter();
            this.seanslarDataSet = new SinemaOtomasyonu.SeanslarDataSet();
            this.seanslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seanslarTableAdapter = new SinemaOtomasyonu.SeanslarDataSetTableAdapters.SeanslarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanslarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanslarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_biletid
            // 
            this.lbl_biletid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_biletid.Location = new System.Drawing.Point(134, 12);
            this.lbl_biletid.Name = "lbl_biletid";
            this.lbl_biletid.Size = new System.Drawing.Size(116, 19);
            this.lbl_biletid.TabIndex = 49;
            this.lbl_biletid.Text = "1";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 48;
            this.label7.Text = "ID:";
            // 
            // cmbx_koltukno
            // 
            this.cmbx_koltukno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbx_koltukno.FormattingEnabled = true;
            this.cmbx_koltukno.Location = new System.Drawing.Point(134, 195);
            this.cmbx_koltukno.Name = "cmbx_koltukno";
            this.cmbx_koltukno.Size = new System.Drawing.Size(238, 26);
            this.cmbx_koltukno.TabIndex = 46;
            // 
            // txt_salon
            // 
            this.txt_salon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_salon.Enabled = false;
            this.txt_salon.Location = new System.Drawing.Point(134, 164);
            this.txt_salon.Name = "txt_salon";
            this.txt_salon.Size = new System.Drawing.Size(238, 25);
            this.txt_salon.TabIndex = 45;
            // 
            // cmbx_seans
            // 
            this.cmbx_seans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbx_seans.FormattingEnabled = true;
            this.cmbx_seans.Location = new System.Drawing.Point(134, 132);
            this.cmbx_seans.Name = "cmbx_seans";
            this.cmbx_seans.Size = new System.Drawing.Size(238, 26);
            this.cmbx_seans.TabIndex = 44;
            this.cmbx_seans.SelectedIndexChanged += new System.EventHandler(this.cmbx_seans_SelectedIndexChanged);
            // 
            // cmbx_film
            // 
            this.cmbx_film.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbx_film.DataSource = this.filmlerBindingSource;
            this.cmbx_film.DisplayMember = "ad";
            this.cmbx_film.FormattingEnabled = true;
            this.cmbx_film.Location = new System.Drawing.Point(134, 100);
            this.cmbx_film.Name = "cmbx_film";
            this.cmbx_film.Size = new System.Drawing.Size(238, 26);
            this.cmbx_film.TabIndex = 43;
            this.cmbx_film.ValueMember = "id";
            this.cmbx_film.SelectedIndexChanged += new System.EventHandler(this.cmbx_film_SelectedIndexChanged);
            // 
            // txt_mail
            // 
            this.txt_mail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_mail.Location = new System.Drawing.Point(134, 69);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(238, 25);
            this.txt_mail.TabIndex = 42;
            // 
            // txt_ad
            // 
            this.txt_ad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_ad.Location = new System.Drawing.Point(134, 38);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(238, 25);
            this.txt_ad.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Location = new System.Drawing.Point(12, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "Mail Adresiniz:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Location = new System.Drawing.Point(12, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Koltuk No:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "Salon:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Seans:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Film:";
            // 
            // btn_temizle
            // 
            this.btn_temizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_temizle.Image = ((System.Drawing.Image)(resources.GetObject("btn_temizle.Image")));
            this.btn_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_temizle.Location = new System.Drawing.Point(12, 231);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(112, 55);
            this.btn_temizle.TabIndex = 51;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.Image")));
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.Location = new System.Drawing.Point(256, 231);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(116, 55);
            this.btn_kaydet.TabIndex = 50;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // filmlerDataSet
            // 
            this.filmlerDataSet.DataSetName = "FilmlerDataSet";
            this.filmlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmlerBindingSource
            // 
            this.filmlerBindingSource.DataMember = "Filmler";
            this.filmlerBindingSource.DataSource = this.filmlerDataSet;
            // 
            // filmlerTableAdapter
            // 
            this.filmlerTableAdapter.ClearBeforeFill = true;
            // 
            // seanslarDataSet
            // 
            this.seanslarDataSet.DataSetName = "SeanslarDataSet";
            this.seanslarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seanslarBindingSource
            // 
            this.seanslarBindingSource.DataMember = "Seanslar";
            this.seanslarBindingSource.DataSource = this.seanslarDataSet;
            // 
            // seanslarTableAdapter
            // 
            this.seanslarTableAdapter.ClearBeforeFill = true;
            // 
            // BiletDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 298);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.lbl_biletid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbx_koltukno);
            this.Controls.Add(this.txt_salon);
            this.Controls.Add(this.cmbx_seans);
            this.Controls.Add(this.cmbx_film);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BiletDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bilet Değiştir";
            this.Load += new System.EventHandler(this.BiletDegistir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmlerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanslarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanslarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_biletid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbx_koltukno;
        private System.Windows.Forms.TextBox txt_salon;
        private System.Windows.Forms.ComboBox cmbx_seans;
        private System.Windows.Forms.ComboBox cmbx_film;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_kaydet;
        private FilmlerDataSet filmlerDataSet;
        private System.Windows.Forms.BindingSource filmlerBindingSource;
        private FilmlerDataSetTableAdapters.FilmlerTableAdapter filmlerTableAdapter;
        private SeanslarDataSet seanslarDataSet;
        private System.Windows.Forms.BindingSource seanslarBindingSource;
        private SeanslarDataSetTableAdapters.SeanslarTableAdapter seanslarTableAdapter;
    }
}