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
    public partial class SalonGuncelle : Form
    {
        public SalonGuncelle()
        {
            InitializeComponent();
        }

        private void salonGetir()
        {
            lbl_salonid.Text = Tanimlamalar.id;
            txt_ad.Text = Tanimlamalar.ad;
            masktxt_kisisayisi.Text = Tanimlamalar.kisisayisi;
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text != "" && masktxt_kisisayisi.Text != "")
            {
                try
                {
                    Form_Vizyon.baglantiac();
                    SqlCommand guncelle = new SqlCommand("UPDATE Salonlar SET ad='" + txt_ad.Text + "', kisisayisi='" + masktxt_kisisayisi.Text + "' WHERE id='" + lbl_salonid.Text + "'", Form_Vizyon.baglanti);
                    guncelle.ExecuteNonQuery();
                    Form_Vizyon.baglantikapa();
                    MessageBox.Show("Salon güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (masktxt_kisisayisi.Text == "")
                {
                    masktxt_kisisayisi.BackColor = Color.DarkRed;
                    masktxt_kisisayisi.ForeColor = Color.White;
                    masktxt_kisisayisi.Focus();
                }
            }
        }

        private void SalonGuncelle_Load(object sender, EventArgs e)
        {
            salonGetir();
        }
    }
}
