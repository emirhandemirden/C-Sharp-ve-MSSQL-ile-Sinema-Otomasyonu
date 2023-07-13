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
    public partial class BiletIade : Form
    {
        public BiletIade()
        {
            InitializeComponent();
        }

        private void BiletIade_Load(object sender, EventArgs e)
        {
            BiletGetir();
        }

        private void BiletGetir()
        {
            label_biletid.Text = Biletler.satir["id"].ToString();
            txt_ad.Text = Biletler.satir["ad"].ToString();
            txt_mail.Text = Biletler.satir["mail"].ToString();
            cmbx_film.Text = Biletler.satir["film"].ToString();
            cmbx_seans.Text = Biletler.satir["seans"].ToString();
            txt_salon.Text = Biletler.satir["salon"].ToString();
            cmbx_koltukno.Text = Biletler.satir["koltukno"].ToString();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show(Biletler.satir["id"].ToString() + " numaralı bileti iade almak istediğinize emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == cevap)
            {
                try
                {
                    Form_Vizyon.baglantiac();
                    SqlCommand sil = new SqlCommand("DELETE FROM Biletler WHERE id='" + label_biletid.Text + "'", Form_Vizyon.baglanti);
                    sil.ExecuteNonQuery();
                    SqlCommand kaydet = new SqlCommand("INSERT INTO BiletGecmisleri (baslik,aciklama,saat,tarih)VALUES('Bilet iade','" + txt_ad.Text + " adlı müşterinin, " + cmbx_film.Text + " adlı filmin " + cmbx_seans.Text + " tarihindeki bileti iade olmuştur.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_Vizyon.baglanti);
                    kaydet.ExecuteNonQuery();
                    Form_Vizyon.baglantikapa();
                    MessageBox.Show("Bilet iadesi tamamlandı.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception hata)
                { MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
