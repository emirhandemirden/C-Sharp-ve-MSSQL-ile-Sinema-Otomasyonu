using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class Form_Vizyon : Form
    {
        public Form_Vizyon()
        {
            InitializeComponent();
            vizyondakileriGetir();
        }

        public static SqlConnection baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = Sinema; Integrated Security = True; MultipleActiveResultSets=True");
        public static void baglantiac() { if (baglanti.State != ConnectionState.Open) baglanti.Open(); }
        public static void baglantikapa() { if (baglanti.State != ConnectionState.Closed) baglanti.Close(); }
        public static string film_bilgi = "";
        Label label, label1, label2, label3, label4, label5;
        Panel panel;
        PictureBox pictureBox;
        Button button, button1;

        // Bu metot tarih sıralamasına göre belirlenen tarihten sonrası seans bilgilerini bir panel içerisine oluşuturulan dizayna göre getirir.
        private void vizyondakileriGetir()
        {
            panel1.Controls.Clear();
            try
            {
                int i = 12, j = 1;
                baglantiac();
                // Seans bilgilerini çekiyoruz.
                SqlCommand vericek = new SqlCommand("SELECT * FROM Seanslar ORDER BY tarih ASC, saat ASC",baglanti);
                // Çekilen seans bilgilerini okuyoruz.
                SqlDataReader oku = vericek.ExecuteReader();
                while (oku.Read())
                {
                    // Seans bilgisi bulunduğumuz tarihten önce olup olmadığını kontrol ediyoruz.
                    if (DateTime.Parse(oku["tarih"].ToString()).Day >= DateTime.Now.Day && DateTime.Parse(oku["tarih"].ToString()).Month >= DateTime.Now.Month && DateTime.Parse(oku["tarih"].ToString()).Year >= DateTime.Now.Year && DateTime.Parse(oku["saat"].ToString()).Hour >= DateTime.Now.Hour)
                    {
                        // Seans bilgisinin saatinin geçip geçmediğini kontrol ediyoruz.
                        if ((DateTime.Parse(oku["saat"].ToString()).Minute >= DateTime.Now.Minute && DateTime.Parse(oku["saat"].ToString()).Hour == DateTime.Now.Hour) || (DateTime.Parse(oku["saat"].ToString()).Hour >= DateTime.Now.Hour))
                        {
                            // Seans'ın filminin verilerini çekiyoruz.
                            SqlCommand vericek2 = new SqlCommand("SELECT * FROM Filmler WHERE ad='" + oku["film"].ToString() + "'", baglanti);
                            // Çekilen verileri okuyoruz.
                            SqlDataReader oku2 = vericek2.ExecuteReader();
                            while (oku2.Read())
                            {
                                // Seans bilgilerini düzenli tutabilmek için paneller içerisine yerleştireceğiz. burada da panelimizi oluşturuyoruz.
                                panel = new Panel()
                                {
                                    Location = new Point(12, i),
                                    Size = new Size(760, 230),
                                    BorderStyle = BorderStyle.FixedSingle
                                };
                                // Label nesnesine film adını yazıyoruz.
                                label = new Label()
                                {
                                    Text = oku["film"].ToString(),
                                    AutoSize = false,
                                    Size = new Size(298, 23),
                                    Font = new Font("Arial", 14, FontStyle.Bold),
                                    Location = new Point(151, 12)
                                };
                                // Filmin kısa bir tarih saat / süre / tür bilgisini yazıyoruz.
                                label1 = new Label()
                                {
                                    Text = oku["tarih"].ToString() + " " + oku["saat"].ToString() + " / " + oku2["sure"].ToString() + " / " + oku2["tur"].ToString(),
                                    AutoSize = false,
                                    Size = new Size(298, 23),
                                    Font = new Font("Arial", 12),
                                    Location = new Point(151, 46)
                                };
                                // Yönetmen bilgisini yazıyoruz.
                                label2 = new Label()
                                {
                                    Text = "Yönetmen: " + oku2["yonetmen"].ToString(),
                                    AutoSize = false,
                                    Size = new Size(298, 23),
                                    Font = new Font("Arial", 12),
                                    Location = new Point(151, 80)
                                };
                                // Oyuncuları yazıyoruz.
                                label3 = new Label()
                                {
                                    Text = "Oyuncular: " + oku2["oyuncular"].ToString(),
                                    AutoSize = false,
                                    Size = new Size(298, 63),
                                    Font = new Font("Arial", 12),
                                    Location = new Point(151, 114)
                                };
                                // Kısa özet başlığını yazıyoruz.
                                label4 = new Label()
                                {
                                    Text = "Kısa Özet",
                                    AutoSize = false,
                                    Size = new Size(298, 23),
                                    Font = new Font("Arial", 14, FontStyle.Bold),
                                    Location = new Point(455, 12)
                                };
                                // Ardından kısa özeti getiriyoruz.
                                label5 = new Label()
                                {
                                    Text = oku2["ozet"].ToString(),
                                    AutoSize = false,
                                    Size = new Size(298, 138),
                                    Font = new Font("Arial", 12),
                                    Location = new Point(455, 41)
                                };
                                // Sonra görselini getiriyoruz
                                pictureBox = new PictureBox()
                                {
                                    Size = new Size(140, 176),
                                    Location = new Point(3, 3),
                                    SizeMode = PictureBoxSizeMode.Zoom,
                                    ImageLocation = "C:\\Users\\PC\\Desktop\\johnwick4.jpg"
                                };
                                // Fragman izle butonunu oluşturuyoruz. Tıklanırsa ilgili tarayıcıda fragman linkini açacaktır.
                                button = new Button()
                                {
                                    Text = "Fragmanı İzle",
                                    AccessibleDescription = oku2["fragmanlink"].ToString(),
                                    Size = new Size(372, 44),
                                    Location = new Point(3, 180)
                                };
                                // Bilet Al butonunu oluşturuyoruz. Tıklanırsa ilgili seans bilgileri ile bilet kesim işlemi için bilet satış ekranına gidecektir.
                                button1 = new Button()
                                {
                                    Text = "Bilet Al",
                                    AccessibleDescription = oku["film"].ToString() + "-" + oku["tarih"].ToString() + "-" + oku["saat"].ToString(),
                                    Size = new Size(372, 44),
                                    Location = new Point(381, 180)
                                };
                                // Oluşturduğumuz paneli önce formda bulunan panelimize daha sonra diğer tüm nesneleri panelimize ekliyoruz.
                                panel1.Controls.Add(panel);
                                panel.Controls.Add(label);
                                panel.Controls.Add(label1);
                                panel.Controls.Add(label2);
                                panel.Controls.Add(label3);
                                panel.Controls.Add(label4);
                                panel.Controls.Add(label5);
                                panel.Controls.Add(pictureBox);
                                panel.Controls.Add(button);
                                panel.Controls.Add(button1);
                                // Butonların 'click' event (olayını) veriyoruz.
                                button.Click += new EventHandler(fragmanizle_click);
                                button1.Click += new EventHandler(biletal_click);
                            }
                            oku2.Close();
                            i += 242;
                        }
                    }
                }
                oku.Close();
                baglantikapa();
            }
            catch (Exception hata)
            { MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void fragmanizle_click(object sender, EventArgs e)
        {
            // Varsayılan tarayıcıda fragman linkini açacaktır. Butonu oluştururken 'AccessibleDescription' kısmına linki vermiştik. Buradan linki alacaktır.
            System.Diagnostics.Process.Start((sender as Button).AccessibleDescription);
        }

        private void biletal_click(object sender, EventArgs e)
        {
            // Film bilgilerini alarak bilet satışa geçecektir.
            film_bilgi = (sender as Button).AccessibleDescription;
            BiletSatis biletSatis = new BiletSatis();
            biletSatis.ShowDialog();
            film_bilgi = "";
        }

        private void tümBiletlerListesiRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BiletlerListesi biletlerListesi = new BiletlerListesi();
            biletlerListesi.ShowDialog();
        }

        private void işlemineGöreBiletGeçmişiListesiRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BiletlerGecmisiListesi biletlerGecmisiListesi = new BiletlerGecmisiListesi();
            biletlerGecmisiListesi.ShowDialog();
        }

        private void filmlerListesiRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilmlerListesi filmlerListesi = new FilmlerListesi();
            filmlerListesi.ShowDialog();
        }

        private void başlığınaGöreFilmlerGeçmişiListesiRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilmlerGecmisiListesi filmlerGecmisiListesi = new FilmlerGecmisiListesi();
            filmlerGecmisiListesi.ShowDialog();
        }

        private void seanslarListesiRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeanslarListesi seanslarListesi = new SeanslarListesi();
            seanslarListesi.ShowDialog();
        }

        private void başlığaGöreSeanslarGeçmişiListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeansGecmisleriListesi seansGecmisleriListesi = new SeansGecmisleriListesi();
            seansGecmisleriListesi.ShowDialog();
        }

        private void personellerListesiRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonellerListesi personellerListesi = new PersonellerListesi();
            personellerListesi.ShowDialog();
        }

        private void başlığaGörePersonelGeçmişleriListesiRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelGecmisleriListesi personelGecmisleriListesi = new PersonelGecmisleriListesi();
            personelGecmisleriListesi.ShowDialog();
        }

        private void filmineGöreSeanslarıListesiRAporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeanslarListesiFilmeGore seanslarListesiFilmeGore = new SeanslarListesiFilmeGore();
            seanslarListesiFilmeGore.ShowDialog();
        }

        private void filmlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filmler filmler = new Filmler();
            filmler.ShowDialog();
        }

        private void seanslarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seanslar seanslar = new Seanslar();
            seanslar.ShowDialog();
            vizyondakileriGetir();
        }

        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personeller personeller = new Personeller();
            personeller.ShowDialog();
        }

        private void Form_Vizyon_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Program kapatılacak devam etmek istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes) { Application.Exit(); }
        }

        private void tanımlamalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tanimlamalar tanimlamalar = new Tanimlamalar();
            tanimlamalar.ShowDialog();
        }

        private void biletİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Biletler biletler = new Biletler();
            biletler.ShowDialog();
        }
    }
}
