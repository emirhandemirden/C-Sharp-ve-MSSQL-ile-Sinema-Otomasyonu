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
    public partial class BiletTurEkle : Form
    {
        public BiletTurEkle()
        {
            InitializeComponent();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_tur.Text != "")
            {
                try
                {
                    Form_Vizyon.baglantiac();
                    SqlCommand kaydet = new SqlCommand("INSERT INTO BiletTurleri (tur)VALUES('" + txt_tur.Text + "')", Form_Vizyon.baglanti);
                    kaydet.ExecuteNonQuery();
                    Form_Vizyon.baglantikapa();
                    MessageBox.Show("Bilet türü eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }
                catch (Exception hata)
                { MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                if (txt_tur.Text == "")
                {
                    txt_tur.BackColor = Color.DarkRed;
                    txt_tur.ForeColor = Color.White;
                    txt_tur.Focus();
                }
            }
        }

        private void temizle()
        {
            txt_tur.Text = "";
            txt_tur.BackColor = Color.White;
            txt_tur.ForeColor = Color.Black;
        }
    }
}
