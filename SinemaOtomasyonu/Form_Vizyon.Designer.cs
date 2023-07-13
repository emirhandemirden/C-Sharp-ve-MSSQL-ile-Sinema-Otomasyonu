namespace SinemaOtomasyonu
{
    partial class Form_Vizyon
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Vizyon));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.biletİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seanslarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletRaporlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümBiletlerListesiRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemineGöreBiletGeçmişiListesiRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmlerRaporlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmlerListesiRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.başlığınaGöreFilmlerGeçmişiListesiRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türüneGöreFİlmlerListesiRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seanslarRaporlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seanslarListesiRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.başlığaGöreSeanslarGeçmişiListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmineGöreSeanslarıListesiRAporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelRaporlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personellerListesiRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.başlığaGörePersonelGeçmişleriListesiRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biletİşlemleriToolStripMenuItem,
            this.filmlerToolStripMenuItem,
            this.seanslarToolStripMenuItem,
            this.personellerToolStripMenuItem,
            this.tanımlamalarToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // biletİşlemleriToolStripMenuItem
            // 
            this.biletİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("biletİşlemleriToolStripMenuItem.Image")));
            this.biletİşlemleriToolStripMenuItem.Name = "biletİşlemleriToolStripMenuItem";
            this.biletİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.biletİşlemleriToolStripMenuItem.Text = "Bilet İşlemleri";
            this.biletİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.biletİşlemleriToolStripMenuItem_Click);
            // 
            // filmlerToolStripMenuItem
            // 
            this.filmlerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filmlerToolStripMenuItem.Image")));
            this.filmlerToolStripMenuItem.Name = "filmlerToolStripMenuItem";
            this.filmlerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.filmlerToolStripMenuItem.Text = "Filmler";
            this.filmlerToolStripMenuItem.Click += new System.EventHandler(this.filmlerToolStripMenuItem_Click);
            // 
            // seanslarToolStripMenuItem
            // 
            this.seanslarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("seanslarToolStripMenuItem.Image")));
            this.seanslarToolStripMenuItem.Name = "seanslarToolStripMenuItem";
            this.seanslarToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.seanslarToolStripMenuItem.Text = "Seanslar";
            this.seanslarToolStripMenuItem.Click += new System.EventHandler(this.seanslarToolStripMenuItem_Click);
            // 
            // personellerToolStripMenuItem
            // 
            this.personellerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personellerToolStripMenuItem.Image")));
            this.personellerToolStripMenuItem.Name = "personellerToolStripMenuItem";
            this.personellerToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.personellerToolStripMenuItem.Text = "Personeller";
            this.personellerToolStripMenuItem.Click += new System.EventHandler(this.personellerToolStripMenuItem_Click);
            // 
            // tanımlamalarToolStripMenuItem
            // 
            this.tanımlamalarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tanımlamalarToolStripMenuItem.Image")));
            this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            this.tanımlamalarToolStripMenuItem.Click += new System.EventHandler(this.tanımlamalarToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biletRaporlarıToolStripMenuItem,
            this.filmlerRaporlarıToolStripMenuItem,
            this.seanslarRaporlarıToolStripMenuItem,
            this.personelRaporlarıToolStripMenuItem});
            this.raporlarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("raporlarToolStripMenuItem.Image")));
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // biletRaporlarıToolStripMenuItem
            // 
            this.biletRaporlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümBiletlerListesiRaporuToolStripMenuItem,
            this.işlemineGöreBiletGeçmişiListesiRaporuToolStripMenuItem});
            this.biletRaporlarıToolStripMenuItem.Name = "biletRaporlarıToolStripMenuItem";
            this.biletRaporlarıToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.biletRaporlarıToolStripMenuItem.Text = "Bilet Raporları";
            // 
            // tümBiletlerListesiRaporuToolStripMenuItem
            // 
            this.tümBiletlerListesiRaporuToolStripMenuItem.Name = "tümBiletlerListesiRaporuToolStripMenuItem";
            this.tümBiletlerListesiRaporuToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.tümBiletlerListesiRaporuToolStripMenuItem.Text = "Biletler Listesi Raporu";
            this.tümBiletlerListesiRaporuToolStripMenuItem.Click += new System.EventHandler(this.tümBiletlerListesiRaporuToolStripMenuItem_Click);
            // 
            // işlemineGöreBiletGeçmişiListesiRaporuToolStripMenuItem
            // 
            this.işlemineGöreBiletGeçmişiListesiRaporuToolStripMenuItem.Name = "işlemineGöreBiletGeçmişiListesiRaporuToolStripMenuItem";
            this.işlemineGöreBiletGeçmişiListesiRaporuToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.işlemineGöreBiletGeçmişiListesiRaporuToolStripMenuItem.Text = "Başlığına Göre Bilet Geçmişi Listesi Raporu";
            this.işlemineGöreBiletGeçmişiListesiRaporuToolStripMenuItem.Click += new System.EventHandler(this.işlemineGöreBiletGeçmişiListesiRaporuToolStripMenuItem_Click);
            // 
            // filmlerRaporlarıToolStripMenuItem
            // 
            this.filmlerRaporlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmlerListesiRaporuToolStripMenuItem,
            this.başlığınaGöreFilmlerGeçmişiListesiRaporuToolStripMenuItem,
            this.türüneGöreFİlmlerListesiRaporuToolStripMenuItem});
            this.filmlerRaporlarıToolStripMenuItem.Name = "filmlerRaporlarıToolStripMenuItem";
            this.filmlerRaporlarıToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.filmlerRaporlarıToolStripMenuItem.Text = "Film Raporları";
            // 
            // filmlerListesiRaporuToolStripMenuItem
            // 
            this.filmlerListesiRaporuToolStripMenuItem.Name = "filmlerListesiRaporuToolStripMenuItem";
            this.filmlerListesiRaporuToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.filmlerListesiRaporuToolStripMenuItem.Text = "Filmler Listesi Raporu";
            this.filmlerListesiRaporuToolStripMenuItem.Click += new System.EventHandler(this.filmlerListesiRaporuToolStripMenuItem_Click);
            // 
            // başlığınaGöreFilmlerGeçmişiListesiRaporuToolStripMenuItem
            // 
            this.başlığınaGöreFilmlerGeçmişiListesiRaporuToolStripMenuItem.Name = "başlığınaGöreFilmlerGeçmişiListesiRaporuToolStripMenuItem";
            this.başlığınaGöreFilmlerGeçmişiListesiRaporuToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.başlığınaGöreFilmlerGeçmişiListesiRaporuToolStripMenuItem.Text = "Başlığına Göre Film Geçmişi Listesi Raporu";
            this.başlığınaGöreFilmlerGeçmişiListesiRaporuToolStripMenuItem.Click += new System.EventHandler(this.başlığınaGöreFilmlerGeçmişiListesiRaporuToolStripMenuItem_Click);
            // 
            // türüneGöreFİlmlerListesiRaporuToolStripMenuItem
            // 
            this.türüneGöreFİlmlerListesiRaporuToolStripMenuItem.Name = "türüneGöreFİlmlerListesiRaporuToolStripMenuItem";
            this.türüneGöreFİlmlerListesiRaporuToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.türüneGöreFİlmlerListesiRaporuToolStripMenuItem.Text = "Türüne göre Fİlmler Listesi Raporu";
            // 
            // seanslarRaporlarıToolStripMenuItem
            // 
            this.seanslarRaporlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seanslarListesiRaporuToolStripMenuItem,
            this.başlığaGöreSeanslarGeçmişiListesiToolStripMenuItem,
            this.filmineGöreSeanslarıListesiRAporuToolStripMenuItem});
            this.seanslarRaporlarıToolStripMenuItem.Name = "seanslarRaporlarıToolStripMenuItem";
            this.seanslarRaporlarıToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.seanslarRaporlarıToolStripMenuItem.Text = "Seans Raporları";
            // 
            // seanslarListesiRaporuToolStripMenuItem
            // 
            this.seanslarListesiRaporuToolStripMenuItem.Name = "seanslarListesiRaporuToolStripMenuItem";
            this.seanslarListesiRaporuToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.seanslarListesiRaporuToolStripMenuItem.Text = "Seanslar Listesi Raporu";
            this.seanslarListesiRaporuToolStripMenuItem.Click += new System.EventHandler(this.seanslarListesiRaporuToolStripMenuItem_Click);
            // 
            // başlığaGöreSeanslarGeçmişiListesiToolStripMenuItem
            // 
            this.başlığaGöreSeanslarGeçmişiListesiToolStripMenuItem.Name = "başlığaGöreSeanslarGeçmişiListesiToolStripMenuItem";
            this.başlığaGöreSeanslarGeçmişiListesiToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.başlığaGöreSeanslarGeçmişiListesiToolStripMenuItem.Text = "Başlığa Göre Seanslar Geçmişi Listesi Raporu";
            this.başlığaGöreSeanslarGeçmişiListesiToolStripMenuItem.Click += new System.EventHandler(this.başlığaGöreSeanslarGeçmişiListesiToolStripMenuItem_Click);
            // 
            // filmineGöreSeanslarıListesiRAporuToolStripMenuItem
            // 
            this.filmineGöreSeanslarıListesiRAporuToolStripMenuItem.Name = "filmineGöreSeanslarıListesiRAporuToolStripMenuItem";
            this.filmineGöreSeanslarıListesiRAporuToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.filmineGöreSeanslarıListesiRAporuToolStripMenuItem.Text = "Filmine Göre Seansları Listesi Raporu";
            this.filmineGöreSeanslarıListesiRAporuToolStripMenuItem.Click += new System.EventHandler(this.filmineGöreSeanslarıListesiRAporuToolStripMenuItem_Click);
            // 
            // personelRaporlarıToolStripMenuItem
            // 
            this.personelRaporlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personellerListesiRaporuToolStripMenuItem,
            this.başlığaGörePersonelGeçmişleriListesiRaporuToolStripMenuItem});
            this.personelRaporlarıToolStripMenuItem.Name = "personelRaporlarıToolStripMenuItem";
            this.personelRaporlarıToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.personelRaporlarıToolStripMenuItem.Text = "Personel Raporları";
            // 
            // personellerListesiRaporuToolStripMenuItem
            // 
            this.personellerListesiRaporuToolStripMenuItem.Name = "personellerListesiRaporuToolStripMenuItem";
            this.personellerListesiRaporuToolStripMenuItem.Size = new System.Drawing.Size(321, 22);
            this.personellerListesiRaporuToolStripMenuItem.Text = "Personeller Listesi Raporu";
            this.personellerListesiRaporuToolStripMenuItem.Click += new System.EventHandler(this.personellerListesiRaporuToolStripMenuItem_Click);
            // 
            // başlığaGörePersonelGeçmişleriListesiRaporuToolStripMenuItem
            // 
            this.başlığaGörePersonelGeçmişleriListesiRaporuToolStripMenuItem.Name = "başlığaGörePersonelGeçmişleriListesiRaporuToolStripMenuItem";
            this.başlığaGörePersonelGeçmişleriListesiRaporuToolStripMenuItem.Size = new System.Drawing.Size(321, 22);
            this.başlığaGörePersonelGeçmişleriListesiRaporuToolStripMenuItem.Text = "Başlığa Göre Personel Geçmişleri Listesi Raporu";
            this.başlığaGörePersonelGeçmişleriListesiRaporuToolStripMenuItem.Click += new System.EventHandler(this.başlığaGörePersonelGeçmişleriListesiRaporuToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 437);
            this.panel1.TabIndex = 1;
            // 
            // Form_Vizyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_Vizyon";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rıdvan Sinema";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Vizyon_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem biletİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seanslarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personellerToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem biletRaporlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümBiletlerListesiRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemineGöreBiletGeçmişiListesiRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmlerRaporlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmlerListesiRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem başlığınaGöreFilmlerGeçmişiListesiRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seanslarRaporlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seanslarListesiRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem başlığaGöreSeanslarGeçmişiListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelRaporlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personellerListesiRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem başlığaGörePersonelGeçmişleriListesiRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem türüneGöreFİlmlerListesiRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmineGöreSeanslarıListesiRAporuToolStripMenuItem;
    }
}

