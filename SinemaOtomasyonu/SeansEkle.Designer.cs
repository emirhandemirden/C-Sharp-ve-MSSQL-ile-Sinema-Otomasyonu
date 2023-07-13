namespace SinemaOtomasyonu
{
    partial class SeansEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeansEkle));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_film = new System.Windows.Forms.ComboBox();
            this.filmlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmlerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmlerDataSet = new SinemaOtomasyonu.FilmlerDataSet();
            this.cmbx_salon = new System.Windows.Forms.ComboBox();
            this.salonlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salonlarDataSet = new SinemaOtomasyonu.SalonlarDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.masktxt_ucret = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.masktxt_saat = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.masktxt_tarih = new System.Windows.Forms.MaskedTextBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.filmlerTableAdapter = new SinemaOtomasyonu.FilmlerDataSetTableAdapters.FilmlerTableAdapter();
            this.salonlarTableAdapter = new SinemaOtomasyonu.SalonlarDataSetTableAdapters.SalonlarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonlarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seans Filmi:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbx_film
            // 
            this.cmbx_film.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbx_film.DataSource = this.filmlerBindingSource;
            this.cmbx_film.DisplayMember = "ad";
            this.cmbx_film.FormattingEnabled = true;
            this.cmbx_film.Location = new System.Drawing.Point(174, 14);
            this.cmbx_film.Name = "cmbx_film";
            this.cmbx_film.Size = new System.Drawing.Size(251, 26);
            this.cmbx_film.TabIndex = 7;
            this.cmbx_film.ValueMember = "ad";
            // 
            // filmlerBindingSource
            // 
            this.filmlerBindingSource.DataMember = "Filmler";
            this.filmlerBindingSource.DataSource = this.filmlerDataSetBindingSource;
            // 
            // filmlerDataSetBindingSource
            // 
            this.filmlerDataSetBindingSource.DataSource = this.filmlerDataSet;
            this.filmlerDataSetBindingSource.Position = 0;
            // 
            // filmlerDataSet
            // 
            this.filmlerDataSet.DataSetName = "FilmlerDataSet";
            this.filmlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbx_salon
            // 
            this.cmbx_salon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbx_salon.DataSource = this.salonlarBindingSource;
            this.cmbx_salon.DisplayMember = "ad";
            this.cmbx_salon.FormattingEnabled = true;
            this.cmbx_salon.Location = new System.Drawing.Point(174, 46);
            this.cmbx_salon.Name = "cmbx_salon";
            this.cmbx_salon.Size = new System.Drawing.Size(251, 26);
            this.cmbx_salon.TabIndex = 9;
            this.cmbx_salon.ValueMember = "id";
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
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seans Salon:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // masktxt_ucret
            // 
            this.masktxt_ucret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.masktxt_ucret.Location = new System.Drawing.Point(174, 78);
            this.masktxt_ucret.Mask = "0000 tl 00 kr";
            this.masktxt_ucret.Name = "masktxt_ucret";
            this.masktxt_ucret.Size = new System.Drawing.Size(251, 25);
            this.masktxt_ucret.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Seans Ücret:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Seans Saat:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // masktxt_saat
            // 
            this.masktxt_saat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.masktxt_saat.Location = new System.Drawing.Point(174, 109);
            this.masktxt_saat.Mask = "00:00";
            this.masktxt_saat.Name = "masktxt_saat";
            this.masktxt_saat.Size = new System.Drawing.Size(251, 25);
            this.masktxt_saat.TabIndex = 12;
            this.masktxt_saat.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Seans Tarih:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // masktxt_tarih
            // 
            this.masktxt_tarih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.masktxt_tarih.Location = new System.Drawing.Point(174, 140);
            this.masktxt_tarih.Mask = "00/00/0000";
            this.masktxt_tarih.Name = "masktxt_tarih";
            this.masktxt_tarih.Size = new System.Drawing.Size(251, 25);
            this.masktxt_tarih.TabIndex = 14;
            this.masktxt_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_temizle.Image = ((System.Drawing.Image)(resources.GetObject("btn_temizle.Image")));
            this.btn_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_temizle.Location = new System.Drawing.Point(12, 184);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(112, 55);
            this.btn_temizle.TabIndex = 17;
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
            this.btn_kaydet.Location = new System.Drawing.Point(309, 184);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(116, 55);
            this.btn_kaydet.TabIndex = 16;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // filmlerTableAdapter
            // 
            this.filmlerTableAdapter.ClearBeforeFill = true;
            // 
            // salonlarTableAdapter
            // 
            this.salonlarTableAdapter.ClearBeforeFill = true;
            // 
            // SeansEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 249);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.masktxt_tarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.masktxt_saat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.masktxt_ucret);
            this.Controls.Add(this.cmbx_salon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbx_film);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SeansEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seans Oluştur";
            this.Load += new System.EventHandler(this.SeansEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonlarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_film;
        private System.Windows.Forms.ComboBox cmbx_salon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox masktxt_ucret;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox masktxt_saat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox masktxt_tarih;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.BindingSource filmlerDataSetBindingSource;
        private FilmlerDataSet filmlerDataSet;
        private System.Windows.Forms.BindingSource filmlerBindingSource;
        private FilmlerDataSetTableAdapters.FilmlerTableAdapter filmlerTableAdapter;
        private SalonlarDataSet salonlarDataSet;
        private System.Windows.Forms.BindingSource salonlarBindingSource;
        private SalonlarDataSetTableAdapters.SalonlarTableAdapter salonlarTableAdapter;
    }
}