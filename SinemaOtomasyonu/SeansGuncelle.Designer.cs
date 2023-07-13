namespace SinemaOtomasyonu
{
    partial class SeansGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeansGuncelle));
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.masktxt_tarih = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.masktxt_saat = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.masktxt_ucret = new System.Windows.Forms.MaskedTextBox();
            this.cmbx_salon = new System.Windows.Forms.ComboBox();
            this.salonlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salonlarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salonlarDataSet = new SinemaOtomasyonu.SalonlarDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbx_film = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_seansid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salonlarTableAdapter = new SinemaOtomasyonu.SalonlarDataSetTableAdapters.SalonlarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.salonlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonlarDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonlarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_temizle
            // 
            this.btn_temizle.Image = ((System.Drawing.Image)(resources.GetObject("btn_temizle.Image")));
            this.btn_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_temizle.Location = new System.Drawing.Point(13, 204);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(112, 55);
            this.btn_temizle.TabIndex = 31;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.Image")));
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.Location = new System.Drawing.Point(310, 204);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(116, 55);
            this.btn_kaydet.TabIndex = 30;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Seans Tarih:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // masktxt_tarih
            // 
            this.masktxt_tarih.Location = new System.Drawing.Point(175, 160);
            this.masktxt_tarih.Mask = "00/00/0000";
            this.masktxt_tarih.Name = "masktxt_tarih";
            this.masktxt_tarih.Size = new System.Drawing.Size(251, 25);
            this.masktxt_tarih.TabIndex = 28;
            this.masktxt_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Seans Saat:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // masktxt_saat
            // 
            this.masktxt_saat.Location = new System.Drawing.Point(175, 129);
            this.masktxt_saat.Mask = "00:00";
            this.masktxt_saat.Name = "masktxt_saat";
            this.masktxt_saat.Size = new System.Drawing.Size(251, 25);
            this.masktxt_saat.TabIndex = 26;
            this.masktxt_saat.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Seans Ücret:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // masktxt_ucret
            // 
            this.masktxt_ucret.Location = new System.Drawing.Point(175, 98);
            this.masktxt_ucret.Mask = "0000 tl 00 kr";
            this.masktxt_ucret.Name = "masktxt_ucret";
            this.masktxt_ucret.Size = new System.Drawing.Size(251, 25);
            this.masktxt_ucret.TabIndex = 24;
            // 
            // cmbx_salon
            // 
            this.cmbx_salon.DataSource = this.salonlarBindingSource;
            this.cmbx_salon.DisplayMember = "ad";
            this.cmbx_salon.FormattingEnabled = true;
            this.cmbx_salon.Location = new System.Drawing.Point(175, 66);
            this.cmbx_salon.Name = "cmbx_salon";
            this.cmbx_salon.Size = new System.Drawing.Size(251, 26);
            this.cmbx_salon.TabIndex = 23;
            this.cmbx_salon.ValueMember = "id";
            // 
            // salonlarBindingSource
            // 
            this.salonlarBindingSource.DataMember = "Salonlar";
            this.salonlarBindingSource.DataSource = this.salonlarDataSetBindingSource;
            // 
            // salonlarDataSetBindingSource
            // 
            this.salonlarDataSetBindingSource.DataSource = this.salonlarDataSet;
            this.salonlarDataSetBindingSource.Position = 0;
            // 
            // salonlarDataSet
            // 
            this.salonlarDataSet.DataSetName = "SalonlarDataSet";
            this.salonlarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Seans Salon:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbx_film
            // 
            this.cmbx_film.FormattingEnabled = true;
            this.cmbx_film.Location = new System.Drawing.Point(175, 34);
            this.cmbx_film.Name = "cmbx_film";
            this.cmbx_film.Size = new System.Drawing.Size(251, 26);
            this.cmbx_film.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Seans Filmi:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_seansid
            // 
            this.lbl_seansid.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seansid.Location = new System.Drawing.Point(177, 10);
            this.lbl_seansid.Name = "lbl_seansid";
            this.lbl_seansid.Size = new System.Drawing.Size(245, 21);
            this.lbl_seansid.TabIndex = 19;
            this.lbl_seansid.Text = "1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Seans ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // salonlarTableAdapter
            // 
            this.salonlarTableAdapter.ClearBeforeFill = true;
            // 
            // SeansGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 268);
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
            this.Controls.Add(this.lbl_seansid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SeansGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seans Güncelle";
            this.Load += new System.EventHandler(this.SeansGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salonlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonlarDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonlarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox masktxt_tarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox masktxt_saat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox masktxt_ucret;
        private System.Windows.Forms.ComboBox cmbx_salon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbx_film;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_seansid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource salonlarDataSetBindingSource;
        private SalonlarDataSet salonlarDataSet;
        private System.Windows.Forms.BindingSource salonlarBindingSource;
        private SalonlarDataSetTableAdapters.SalonlarTableAdapter salonlarTableAdapter;
    }
}