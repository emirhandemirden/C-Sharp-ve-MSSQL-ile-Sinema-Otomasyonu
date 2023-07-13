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
    public partial class SeansEkle : Form
    {
        public SeansEkle()
        {
            InitializeComponent();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (masktxt_tarih.Text != "  .  ." && masktxt_saat.Text != "  :" && masktxt_ucret.Text != "     tl    kr" && cmbx_salon.Text != "" && cmbx_film.Text != "")
            {
                try
                {
                    Form_Vizyon.baglantiac();
                    SqlCommand kaydet = new SqlCommand("INSERT INTO Seanslar (film,salon,ucret,saat,tarih)VALUES('" + cmbx_film.Text + "','" + cmbx_salon.Text + "','" + masktxt_ucret.Text + "','" + masktxt_saat.Text + "','" + masktxt_tarih.Text + "')", Form_Vizyon.baglanti);
                    kaydet.ExecuteNonQuery();
                    kaydet = new SqlCommand("INSERT INTO SeansGecmisleri (baslik,aciklama,saat,tarih)VALUES('Seans oluşturma','" + cmbx_film.Text + " adlı filmin seansı " + masktxt_tarih.Text + " tarihi " + masktxt_saat.Text + " saatinde oluşturuldu.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_Vizyon.baglanti);
                    kaydet.ExecuteNonQuery();
                    Form_Vizyon.baglantikapa();
                    temizle();
                    MessageBox.Show("Seans başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception hata)
                { MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                if (masktxt_tarih.Text == "  .  .")
                {
                    masktxt_tarih.BackColor = Color.DarkRed;
                    masktxt_tarih.ForeColor = Color.White;
                    masktxt_tarih.Focus();
                }
                if (masktxt_saat.Text == "  :")
                {
                    masktxt_saat.BackColor = Color.DarkRed;
                    masktxt_saat.ForeColor = Color.White;
                    masktxt_saat.Focus();
                }
                if (masktxt_ucret.Text == "     tl    kr")
                {
                    masktxt_ucret.BackColor = Color.DarkRed;
                    masktxt_ucret.ForeColor = Color.White;
                    masktxt_ucret.Focus();
                }
                if (cmbx_salon.Text == "")
                {
                    cmbx_salon.BackColor = Color.DarkRed;
                    cmbx_salon.ForeColor = Color.White;
                    cmbx_salon.Focus();
                }
                if (cmbx_film.Text == "")
                {
                    cmbx_film.BackColor = Color.DarkRed;
                    cmbx_film.ForeColor = Color.White;
                    cmbx_film.Focus();
                }
            }
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void temizle()
        {
            cmbx_film.SelectedIndex = 0;
            cmbx_salon.SelectedIndex = 0;
            masktxt_ucret.Text = "";
            masktxt_saat.Text = "";
            masktxt_tarih.Text = "";
            masktxt_tarih.BackColor = Color.White;
            masktxt_tarih.ForeColor = Color.Black;
            masktxt_saat.BackColor = Color.White;
            masktxt_saat.ForeColor = Color.Black;
            masktxt_ucret.BackColor = Color.White;
            masktxt_ucret.ForeColor = Color.Black;
            cmbx_salon.BackColor = Color.White;
            cmbx_salon.ForeColor = Color.Black;
            cmbx_film.BackColor = Color.White;
            cmbx_film.ForeColor = Color.Black;
        }

        private void SeansEkle_Load(object sender, EventArgs e)
        {
            salonlarTableAdapter.Fill(salonlarDataSet.Salonlar);
            filmlerTableAdapter.Fill(filmlerDataSet.Filmler);
            if (Filmler.seansekle) cmbx_film.Text = Filmler.row["ad"].ToString();
        }
    }
}
