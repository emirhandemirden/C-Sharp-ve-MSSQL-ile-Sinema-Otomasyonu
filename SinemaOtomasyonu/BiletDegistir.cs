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
    public partial class BiletDegistir : Form
    {
        public BiletDegistir()
        {
            InitializeComponent();
        }

        private void BiletGetir()
        {
            // Güncellenmek üzere seçili olan biletin bilgileri alınır.
            lbl_biletid.Text = Biletler.satir["id"].ToString();
            txt_ad.Text = Biletler.satir["ad"].ToString();
            txt_mail.Text = Biletler.satir["mail"].ToString();
            cmbx_film.Text = Biletler.satir["film"].ToString();
            cmbx_seans.Text = Biletler.satir["seans"].ToString();
            txt_salon.Text = Biletler.satir["salon"].ToString();
            cmbx_koltukno.Text = Biletler.satir["koltukno"].ToString();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text != "" && txt_mail.Text != "" && cmbx_film.Text != "" && cmbx_seans.Text != "" && cmbx_koltukno.Text != "" && txt_salon.Text != "")
            {
                try
                {
                    Form_Vizyon.baglantiac();
                    SqlCommand kaydet = new SqlCommand("UPDATE Biletler SET film='" + cmbx_film.Text + "',seans='" + cmbx_seans.Text + "',salon='" + txt_salon.Text + "',koltukno='" + cmbx_koltukno.Text + "',ad='" + txt_ad.Text + "',mail='" + txt_mail.Text + "' WHERE id='" + lbl_biletid.Text +"'", Form_Vizyon.baglanti);
                    kaydet.ExecuteNonQuery();
                    kaydet = new SqlCommand("INSERT INTO BiletGecmisleri (baslik,aciklama,saat,tarih)VALUES('Bilet değiştirme','" + txt_ad.Text + " adlı müşteri, " + cmbx_film.Text + " adlı filmin " + cmbx_seans.Text + " tarihinde olan seansına bilet bilgilerini güncelledi.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_Vizyon.baglanti);
                    kaydet.ExecuteNonQuery();
                    Form_Vizyon.baglantikapa();
                    MessageBox.Show("Seans başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception hata)
                { MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                if (txt_ad.Text == "")
                {
                    txt_ad.BackColor = Color.DarkRed;
                    txt_ad.ForeColor = Color.White;
                    txt_ad.Focus();
                }
                if (txt_mail.Text == "")
                {
                    txt_mail.BackColor = Color.DarkRed;
                    txt_mail.ForeColor = Color.White;
                    txt_mail.Focus();
                }
                if (cmbx_film.Text == "")
                {
                    cmbx_film.BackColor = Color.DarkRed;
                    cmbx_film.ForeColor = Color.White;
                    cmbx_film.Focus();
                }
                if (cmbx_seans.Text == "")
                {
                    cmbx_seans.BackColor = Color.DarkRed;
                    cmbx_seans.ForeColor = Color.White;
                    cmbx_seans.Focus();
                }
                if (txt_salon.Text == "")
                {
                    txt_salon.BackColor = Color.DarkRed;
                    txt_salon.ForeColor = Color.White;
                    txt_salon.Focus();
                }
                if (cmbx_koltukno.Text == "")
                {
                    cmbx_koltukno.BackColor = Color.DarkRed;
                    cmbx_koltukno.ForeColor = Color.White;
                    cmbx_koltukno.Focus();
                }
            }
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void temizle()
        {
            BiletGetir();
            txt_ad.Text = "";
            txt_mail.Text = "";
            txt_salon.Text = "";
            cmbx_film.SelectedIndex = 0;
            cmbx_seans.SelectedIndex = 0;
            cmbx_koltukno.SelectedIndex = 0;
            txt_ad.BackColor = Color.White;
            txt_ad.ForeColor = Color.Black;
            txt_mail.BackColor = Color.White;
            txt_mail.ForeColor = Color.Black;
            txt_salon.BackColor = Color.White;
            txt_salon.ForeColor = Color.Black;
            cmbx_seans.BackColor = Color.White;
            cmbx_seans.ForeColor = Color.Black;
            cmbx_koltukno.BackColor = Color.White;
            cmbx_koltukno.ForeColor = Color.Black;
            cmbx_film.BackColor = Color.White;
            cmbx_film.ForeColor = Color.Black;
        }

        private void seansGetir()
        {
            try
            {
                // her film seçiminde seanslar geleceğinden önceki seçimin seansları her seferinde temizlenecektir.
                cmbx_seans.Items.Clear();
                Form_Vizyon.baglantiac();
                // seçili filmin seans bilgilerini aldığımız komut.
                SqlCommand al = new SqlCommand("SELECT * FROM Seanslar WHERE film='" + cmbx_film.Text + "'", Form_Vizyon.baglanti);
                // verileri okuyoruz.
                SqlDataReader verioku = al.ExecuteReader();
                while (verioku.Read())
                {
                    // geçerli bilgisayar saat ve tarih bilgilerinden sonrasında yani süresi dolmamış olan seans bilgilerini getirecektir.
                    if (DateTime.Parse(verioku["tarih"].ToString()).Day >= DateTime.Now.Day && DateTime.Parse(verioku["tarih"].ToString()).Month >= DateTime.Now.Month && DateTime.Parse(verioku["tarih"].ToString()).Year >= DateTime.Now.Year && DateTime.Parse(verioku["saat"].ToString()).Hour >= DateTime.Now.Hour)
                    {
                        // saat ve dakika kontrolü burada da yapılıyor. Eğer seansın zamanı geçmemiş ise ilgili combobox nesnesine ekleniyor.
                        if ((DateTime.Parse(verioku["saat"].ToString()).Minute >= DateTime.Now.Minute && DateTime.Parse(verioku["saat"].ToString()).Hour == DateTime.Now.Hour) || (DateTime.Parse(verioku["saat"].ToString()).Hour >= DateTime.Now.Hour))
                            cmbx_seans.Items.Add(verioku["salon"].ToString() + " " + verioku["tarih"].ToString() + " " + verioku["saat"].ToString());
                    }
                    // gün kısmında bir önceki if de tarih bir sonraki ay olup günü düşük olursa girmeyeceğinden bu kısımda aynı işlemler gün farketmeksizin en az 1 ay sonrası seans bilgileri içindir.
                    else if (DateTime.Parse(verioku["tarih"].ToString()).Month > DateTime.Now.Month && DateTime.Parse(verioku["tarih"].ToString()).Year >= DateTime.Now.Year && DateTime.Parse(verioku["saat"].ToString()).Hour >= DateTime.Now.Hour)
                        if ((DateTime.Parse(verioku["saat"].ToString()).Minute >= DateTime.Now.Minute && DateTime.Parse(verioku["saat"].ToString()).Hour == DateTime.Now.Hour) || (DateTime.Parse(verioku["saat"].ToString()).Hour >= DateTime.Now.Hour))
                            cmbx_seans.Items.Add(verioku["salon"].ToString() + " " + verioku["tarih"].ToString() + " " + verioku["saat"].ToString());
                }
                verioku.Close();
                Form_Vizyon.baglantikapa();
                cmbx_seans.SelectedIndex = 0;
                // anasayfada gelen seanslardan bilet işlemine geçişlerde burası kullanılmaktadır. eğer Form_Vizyon.film_bilgi boş değilse anasayfadan seçildiği anlaşılacaktır.
                if (Form_Vizyon.film_bilgi != "")
                {
                    // bilgiyi '-' e göre bir diziye ayırıyoruz.
                    string[] seans = Form_Vizyon.film_bilgi.Split('-');
                    // film bilgisini giriyoruz.
                    cmbx_film.Text = seans[0];
                    // burada ise seçilerek gelinen filmin seans bilgilerini eşleştirerek buluyoruz. doğrusu bulunduğunda seçiyoruz.
                    for (int i = 0; i < cmbx_seans.Items.Count; i++)
                    {
                        for (int j = 0; j < cmbx_seans.Items.Count; j++)
                        {
                            string[] seans1 = cmbx_seans.Items[j].ToString().Split(' ');
                            if (seans[1] + seans[2] == seans1[2] + seans1[3])
                            {
                                cmbx_seans.SelectedIndex = j;
                            }
                        }
                    }
                }
            }
            catch (Exception hata)
            { MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void koltukGetir()
        {
            try
            {
                // her seans değişiminde farklı bilgiler gelebileceğinden koltukno combobox nesnesinin item değerlerini siliyoruz.
                cmbx_koltukno.Items.Clear();
                int koltuksayisi = 0;
                Form_Vizyon.baglantiac();
                // geçerli salonun koltuk bilgilerini almak için komutta filtreliyoruz.
                SqlCommand al = new SqlCommand("SELECT * FROM Salonlar WHERE ad='" + txt_salon.Text + "'", Form_Vizyon.baglanti);
                // verileri okuyoruz.
                SqlDataReader verioku = al.ExecuteReader();
                if (verioku.Read())
                {
                    // Salonun koltuk sayısını alıyoruz.
                    koltuksayisi = int.Parse(verioku["kisisayisi"].ToString());
                }
                verioku.Close();
                for (int i = 1; i <= koltuksayisi; i++)
                {
                    // biletler içerisinde seçili filmin seçili seansının seçili koltukları var mı kontrol ettiğimiz komutumuzu yazdık. 
                    al = new SqlCommand("SELECT * FROM Biletler WHERE film='" + cmbx_film.Text + "' AND seans='" + cmbx_seans.Text + "' AND koltukno='Koltuk " + i + "'", Form_Vizyon.baglanti);
                    // verileri okuyoruz.
                    verioku = al.ExecuteReader();
                    // eğer koltuk seçili olan bir koltuksa eklenmeyecek aksi takdirde seçili olmayan koltuklar yani önceden satın alınmamış koltuklar eklenecektir.
                    if (!verioku.Read())
                        cmbx_koltukno.Items.Add("Koltuk " + i);
                }
                Form_Vizyon.baglantikapa();
                cmbx_koltukno.SelectedIndex = 0;
            }
            catch (Exception hata)
            { MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BiletDegistir_Load(object sender, EventArgs e)
        {
            seanslarTableAdapter.Fill(seanslarDataSet.Seanslar);
            BiletGetir();
            filmlerTableAdapter.Fill(filmlerDataSet.Filmler);
            seansGetir();
        }

        private void cmbx_film_SelectedIndexChanged(object sender, EventArgs e)
        {
            // seçilen filmin seans bilgilerini almak için seansgetir() metotu çağırılıyor.
            seansGetir();
        }

        private void cmbx_seans_SelectedIndexChanged(object sender, EventArgs e)
        {
            // seans bilgierini Split() metodu yardımı ile boşluk karakterince ayırıyoruz ve salon adlı string türündeki diziye ekliyoruz.
            string[] salon = cmbx_seans.Text.Split(' ');
            // Salon bilgisi için ilgili kısımları textboxa aktarıyoruz.
            txt_salon.Text = salon[0] + " " + salon[1];
            // seansın bulunduğu salonun koltuk bilgilerini getirmek için koltukgetir() adlı metodumuza gidiyoruz.
            koltukGetir();
        }
    }
}
