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
    public partial class SeansSil : Form
    {
        public SeansSil()
        {
            InitializeComponent();
        }

        private void seansGetir()
        {
            lbl_seansid.Text = Seanslar.satir["id"].ToString();
            txt_film.Text = Seanslar.satir["film"].ToString();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(Seanslar.satir["film"].ToString() + " filminin seansını kaldırmak istediğinize emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                try
                {
                    Form_Vizyon.baglantiac();
                    SqlCommand sil = new SqlCommand("DELETE FROM Seanslar WHERE id='" + Seanslar.satir["id"].ToString() + "'", Form_Vizyon.baglanti);
                    sil.ExecuteNonQuery();
                    SqlCommand kaydet = new SqlCommand("INSERT INTO SeansGecmisleri (baslik,aciklama,saat,tarih)VALUES('Seans silme','" + txt_film.Text + " adlı filmin seansı silindi.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_Vizyon.baglanti);
                    kaydet.ExecuteNonQuery();
                    Form_Vizyon.baglantikapa();
                    MessageBox.Show("Seans kaldırıldı.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception hata) { MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void SeansSil_Load(object sender, EventArgs e)
        {
            seansGetir();
        }
    }
}
