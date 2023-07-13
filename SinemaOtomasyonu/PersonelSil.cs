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
    public partial class PersonelSil : Form
    {
        public PersonelSil()
        {
            InitializeComponent();
        }

        private void PersonelGetir()
        {
            lbl_personelid.Text = Personeller.satir["id"].ToString();
            txt_ad.Text = Personeller.satir["ad"].ToString();
        }


        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(Personeller.satir["id"].ToString() + " personelini kaldırmak istediğinize emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                try
                {
                    Form_Vizyon.baglantiac();
                    SqlCommand sil = new SqlCommand("DELETE FROM Personeller WHERE id='" + Personeller.satir["id"].ToString() + "'", Form_Vizyon.baglanti);
                    sil.ExecuteNonQuery();
                    SqlCommand kaydet = new SqlCommand("INSERT INTO PersonelGecmisleri (baslik,aciklama,saat,tarih)VALUES('Personl silme','" + txt_ad.Text + " adlı personel silindi.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_Vizyon.baglanti);
                    kaydet.ExecuteNonQuery();
                    Form_Vizyon.baglantikapa();
                    MessageBox.Show("Personel silindi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception hata)
                { MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void PersonelSil_Load(object sender, EventArgs e)
        {
            PersonelGetir();
        }
    }
}
