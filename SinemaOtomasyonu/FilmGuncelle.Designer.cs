namespace SinemaOtomasyonu
{
    partial class FilmGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmGuncelle));
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.rtxt_ozet = new System.Windows.Forms.RichTextBox();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_oyuncular = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_yonetmen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbx_tur = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.masktxt_sure = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.masktxt_tarih = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_filmid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filmTurleriDataSet = new SinemaOtomasyonu.FilmTurleriDataSet();
            this.filmTurleriDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTurleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTurleriTableAdapter = new SinemaOtomasyonu.FilmTurleriDataSetTableAdapters.FilmTurleriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.filmTurleriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTurleriDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTurleriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_temizle
            // 
            this.btn_temizle.Image = ((System.Drawing.Image)(resources.GetObject("btn_temizle.Image")));
            this.btn_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_temizle.Location = new System.Drawing.Point(12, 395);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(112, 55);
            this.btn_temizle.TabIndex = 40;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.Image")));
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.Location = new System.Drawing.Point(332, 395);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(116, 55);
            this.btn_kaydet.TabIndex = 39;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // rtxt_ozet
            // 
            this.rtxt_ozet.Location = new System.Drawing.Point(203, 225);
            this.rtxt_ozet.Name = "rtxt_ozet";
            this.rtxt_ozet.Size = new System.Drawing.Size(245, 121);
            this.rtxt_ozet.TabIndex = 38;
            this.rtxt_ozet.Text = "";
            // 
            // txt_link
            // 
            this.txt_link.Location = new System.Drawing.Point(203, 352);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(245, 25);
            this.txt_link.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 21);
            this.label9.TabIndex = 36;
            this.label9.Text = "Film Fragman Linki:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 21);
            this.label8.TabIndex = 35;
            this.label8.Text = "Film Hakkında Özet:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_oyuncular
            // 
            this.txt_oyuncular.Location = new System.Drawing.Point(203, 193);
            this.txt_oyuncular.Name = "txt_oyuncular";
            this.txt_oyuncular.Size = new System.Drawing.Size(245, 25);
            this.txt_oyuncular.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 21);
            this.label7.TabIndex = 33;
            this.label7.Text = "Film Oyuncuları:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_yonetmen
            // 
            this.txt_yonetmen.Location = new System.Drawing.Point(203, 162);
            this.txt_yonetmen.Name = "txt_yonetmen";
            this.txt_yonetmen.Size = new System.Drawing.Size(245, 25);
            this.txt_yonetmen.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "Film Yönetmeni:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbx_tur
            // 
            this.cmbx_tur.DataSource = this.filmTurleriBindingSource;
            this.cmbx_tur.DisplayMember = "tur";
            this.cmbx_tur.FormattingEnabled = true;
            this.cmbx_tur.Location = new System.Drawing.Point(203, 130);
            this.cmbx_tur.Name = "cmbx_tur";
            this.cmbx_tur.Size = new System.Drawing.Size(245, 26);
            this.cmbx_tur.TabIndex = 30;
            this.cmbx_tur.ValueMember = "id";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Film Türü:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // masktxt_sure
            // 
            this.masktxt_sure.Location = new System.Drawing.Point(203, 99);
            this.masktxt_sure.Mask = "0s 00dk";
            this.masktxt_sure.Name = "masktxt_sure";
            this.masktxt_sure.Size = new System.Drawing.Size(245, 25);
            this.masktxt_sure.TabIndex = 28;
            this.masktxt_sure.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Film Süresi:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // masktxt_tarih
            // 
            this.masktxt_tarih.Location = new System.Drawing.Point(203, 68);
            this.masktxt_tarih.Mask = "00/00/0000";
            this.masktxt_tarih.Name = "masktxt_tarih";
            this.masktxt_tarih.Size = new System.Drawing.Size(245, 25);
            this.masktxt_tarih.TabIndex = 26;
            this.masktxt_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Film Vizyona Tarihi:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(203, 37);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(245, 25);
            this.txt_ad.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Film Ad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_filmid
            // 
            this.lbl_filmid.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filmid.Location = new System.Drawing.Point(203, 13);
            this.lbl_filmid.Name = "lbl_filmid";
            this.lbl_filmid.Size = new System.Drawing.Size(245, 21);
            this.lbl_filmid.TabIndex = 22;
            this.lbl_filmid.Text = "1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Film ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filmTurleriDataSet
            // 
            this.filmTurleriDataSet.DataSetName = "FilmTurleriDataSet";
            this.filmTurleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmTurleriDataSetBindingSource
            // 
            this.filmTurleriDataSetBindingSource.DataSource = this.filmTurleriDataSet;
            this.filmTurleriDataSetBindingSource.Position = 0;
            // 
            // filmTurleriBindingSource
            // 
            this.filmTurleriBindingSource.DataMember = "FilmTurleri";
            this.filmTurleriBindingSource.DataSource = this.filmTurleriDataSetBindingSource;
            // 
            // filmTurleriTableAdapter
            // 
            this.filmTurleriTableAdapter.ClearBeforeFill = true;
            // 
            // FilmGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 461);
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
            this.Controls.Add(this.lbl_filmid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FilmGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Film Güncelle";
            this.Load += new System.EventHandler(this.FilmGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmTurleriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTurleriDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTurleriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.RichTextBox rtxt_ozet;
        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_oyuncular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_yonetmen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbx_tur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox masktxt_sure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox masktxt_tarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_filmid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource filmTurleriDataSetBindingSource;
        private FilmTurleriDataSet filmTurleriDataSet;
        private System.Windows.Forms.BindingSource filmTurleriBindingSource;
        private FilmTurleriDataSetTableAdapters.FilmTurleriTableAdapter filmTurleriTableAdapter;
    }
}