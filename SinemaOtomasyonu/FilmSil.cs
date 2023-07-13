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
    public partial class FilmSil : Form
    {
        public FilmSil()
        {
            InitializeComponent();
        }

        private void filmGetir()
        {
            lbl_filmid.Text = Filmler.row["id"].ToString();
            txt_ad.Text = Filmler.row["ad"].ToString();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show(Filmler.row["ad"].ToString() + " filmini silmek istediğinize emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == cevap)
            {
                try
                {
                    Form_Vizyon.baglantiac();
                    SqlCommand sil = new SqlCommand("DELETE FROM Filmler WHERE id='" + Filmler.row["id"].ToString() + "'", Form_Vizyon.baglanti);
                    sil.ExecuteNonQuery();
                    SqlCommand kaydet = new SqlCommand("INSERT INTO FilmGecmisleri (baslik,aciklama,saat,tarih)VALUES('Film silme','" + txt_ad.Text + " adlı film silindi.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_Vizyon.baglanti);
                    kaydet.ExecuteNonQuery();
                    Form_Vizyon.baglantikapa();
                    MessageBox.Show("Film silindi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception hata)
                { MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void FilmSil_Load(object sender, EventArgs e)
        {
            filmGetir();
        }
    }
}
