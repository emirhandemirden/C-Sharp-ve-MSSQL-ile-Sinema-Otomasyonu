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
    public partial class BiletTurGuncelle : Form
    {
        public BiletTurGuncelle()
        {
            InitializeComponent();
        }

        private void BiletTurGuncelle_Load(object sender, EventArgs e)
        {
            turGetir();
        }

        private void turGetir()
        {
            lbl_turid.Text = Tanimlamalar.id;
            txt_tur.Text = Tanimlamalar.satir;
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_tur.Text != "")
            {
                try
                {
                    Form_Vizyon.baglantiac();
                    SqlCommand guncelle = new SqlCommand("UPDATE BiletTurleri SET tur='" + txt_tur.Text + "' WHERE id='" + lbl_turid.Text + "'", Form_Vizyon.baglanti);
                    guncelle.ExecuteNonQuery();
                    Form_Vizyon.baglantikapa();
                    MessageBox.Show("Bilet türü güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
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
    }
}
