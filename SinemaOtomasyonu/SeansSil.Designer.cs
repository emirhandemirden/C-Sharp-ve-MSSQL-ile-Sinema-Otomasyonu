namespace SinemaOtomasyonu
{
    partial class SeansSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeansSil));
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_seansid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_film = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Seans Filmi:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_seansid
            // 
            this.lbl_seansid.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seansid.Location = new System.Drawing.Point(176, 9);
            this.lbl_seansid.Name = "lbl_seansid";
            this.lbl_seansid.Size = new System.Drawing.Size(199, 21);
            this.lbl_seansid.TabIndex = 23;
            this.lbl_seansid.Text = "1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Seans ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_film
            // 
            this.txt_film.Enabled = false;
            this.txt_film.Location = new System.Drawing.Point(176, 33);
            this.txt_film.Name = "txt_film";
            this.txt_film.Size = new System.Drawing.Size(199, 25);
            this.txt_film.TabIndex = 26;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_kaydet.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.btn_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.Image")));
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.Location = new System.Drawing.Point(150, 71);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(88, 55);
            this.btn_kaydet.TabIndex = 41;
            this.btn_kaydet.Text = "Sil";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // SeansSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 137);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_film);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_seansid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SeansSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seans Sil";
            this.Load += new System.EventHandler(this.SeansSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_seansid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_film;
        private System.Windows.Forms.Button btn_kaydet;
    }
}