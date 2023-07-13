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
    public partial class SalonEkle : Form
    {
        public SalonEkle()
        {
            InitializeComponent();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text != "" && masktxt_kisisayisi.Text != "")
            {
                try
                {
                    Form_Vizyon.baglantiac();
                    SqlCommand kaydet = new SqlCommand("INSERT INTO Salonlar (ad,kisisayisi)VALUES('" + txt_ad.Text + "','" + masktxt_kisisayisi.Text + "')", Form_Vizyon.baglanti);
                    kaydet.ExecuteNonQuery();
                    Form_Vizyon.baglantikapa();
                    MessageBox.Show("Salon eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
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

        private void temizle()
        {
            txt_ad.Text = "";
            masktxt_kisisayisi.Text = "";
            txt_ad.BackColor = Color.White;
            txt_ad.ForeColor = Color.Black;
            masktxt_kisisayisi.BackColor = Color.White;
            masktxt_kisisayisi.ForeColor = Color.Black;
        }
    }
}
