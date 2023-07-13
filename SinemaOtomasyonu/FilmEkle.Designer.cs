namespace SinemaOtomasyonu
{
    partial class FilmEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmEkle));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.masktxt_tarih = new System.Windows.Forms.MaskedTextBox();
            this.masktxt_sure = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbx_tur = new System.Windows.Forms.ComboBox();
            this.txt_yonetmen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_oyuncular = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rtxt_ozet = new System.Windows.Forms.RichTextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.filmTurleriDataSet = new SinemaOtomasyonu.FilmTurleriDataSet();
            this.filmTurleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTurleriTableAdapter = new SinemaOtomasyonu.FilmTurleriDataSetTableAdapters.FilmTurleriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.filmTurleriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTurleriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Film Ad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ad
            // 
            this.txt_ad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_ad.Location = new System.Drawing.Point(203, 14);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(245, 25);
            this.txt_ad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Film Vizyona Tarihi:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // masktxt_tarih
            // 
            this.masktxt_tarih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.masktxt_tarih.Location = new System.Drawing.Point(203, 45);
            this.masktxt_tarih.Mask = "00/00/0000";
            this.masktxt_tarih.Name = "masktxt_tarih";
            this.masktxt_tarih.Size = new System.Drawing.Size(245, 25);
            this.masktxt_tarih.TabIndex = 2;
            this.masktxt_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // masktxt_sure
            // 
            this.masktxt_sure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.masktxt_sure.Location = new System.Drawing.Point(203, 76);
            this.masktxt_sure.Mask = "0s 00dk";
            this.masktxt_sure.Name = "masktxt_sure";
            this.masktxt_sure.Size = new System.Drawing.Size(245, 25);
            this.masktxt_sure.TabIndex = 3;
            this.masktxt_sure.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Film Süresi:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Film Türü:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbx_tur
            // 
            this.cmbx_tur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbx_tur.DataSource = this.filmTurleriBindingSource;
            this.cmbx_tur.DisplayMember = "tur";
            this.cmbx_tur.FormattingEnabled = true;
            this.cmbx_tur.Location = new System.Drawing.Point(203, 107);
            this.cmbx_tur.Name = "cmbx_tur";
            this.cmbx_tur.Size = new System.Drawing.Size(245, 26);
            this.cmbx_tur.TabIndex = 4;
            this.cmbx_tur.ValueMember = "id";
            // 
            // txt_yonetmen
            // 
            this.txt_yonetmen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_yonetmen.Location = new System.Drawing.Point(203, 139);
            this.txt_yonetmen.Name = "txt_yonetmen";
            this.txt_yonetmen.Size = new System.Drawing.Size(245, 25);
            this.txt_yonetmen.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Film Yönetmeni:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_oyuncular
            // 
            this.txt_oyuncular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_oyuncular.Location = new System.Drawing.Point(203, 170);
            this.txt_oyuncular.Name = "txt_oyuncular";
            this.txt_oyuncular.Size = new System.Drawing.Size(245, 25);
            this.txt_oyuncular.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Film Oyuncuları:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Film Hakkında Özet:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_link
            // 
            this.txt_link.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_link.Location = new System.Drawing.Point(203, 329);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(245, 25);
            this.txt_link.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Film Fragman Linki:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtxt_ozet
            // 
            this.rtxt_ozet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rtxt_ozet.Location = new System.Drawing.Point(203, 202);
            this.rtxt_ozet.Name = "rtxt_ozet";
            this.rtxt_ozet.Size = new System.Drawing.Size(245, 121);
            this.rtxt_ozet.TabIndex = 7;
            this.rtxt_ozet.Text = "";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.Image")));
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.Location = new System.Drawing.Point(332, 372);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(116, 55);
            this.btn_kaydet.TabIndex = 9;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_temizle.Image = ((System.Drawing.Image)(resources.GetObject("btn_temizle.Image")));
            this.btn_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_temizle.Location = new System.Drawing.Point(12, 372);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(112, 55);
            this.btn_temizle.TabIndex = 10;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // filmTurleriDataSet
            // 
            this.filmTurleriDataSet.DataSetName = "FilmTurleriDataSet";
            this.filmTurleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmTurleriBindingSource
            // 
            this.filmTurleriBindingSource.DataMember = "FilmTurleri";
            this.filmTurleriBindingSource.DataSource = this.filmTurleriDataSet;
            // 
            // filmTurleriTableAdapter
            // 
            this.filmTurleriTableAdapter.ClearBeforeFill = true;
            // 
            // FilmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 438);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.rtxt_ozet);
            this.Controls.Add(this.txt_link);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_oyuncular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_yonetmen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbx_tur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.masktxt_sure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.masktxt_tarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FilmEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Film Ekle";
            this.Load += new System.EventHandler(this.FilmEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmTurleriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTurleriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox masktxt_tarih;
        private System.Windows.Forms.MaskedTextBox masktxt_sure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbx_tur;
        private System.Windows.Forms.TextBox txt_yonetmen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_oyuncular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtxt_ozet;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_temizle;
        private FilmTurleriDataSet filmTurleriDataSet;
        private System.Windows.Forms.BindingSource filmTurleriBindingSource;
        private FilmTurleriDataSetTableAdapters.FilmTurleriTableAdapter filmTurleriTableAdapter;
    }
}