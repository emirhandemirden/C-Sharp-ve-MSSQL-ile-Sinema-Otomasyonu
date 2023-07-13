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
    public partial class SeansGuncelle : Form
    {
        public SeansGuncelle()
        {
            InitializeComponent();
        }

        private void SeansGetir()
        {
            lbl_seansid.Text = Seanslar.satir["id"].ToString();
            cmbx_film.Text = Seanslar.satir["film"].ToString();
            cmbx_salon.Text = Seanslar.satir["salon"].ToString();
            masktxt_ucret.Text = Seanslar.satir["ucret"].ToString();
            masktxt_saat.Text = Seanslar.satir["saat"].ToString();
            masktxt_tarih.Text = Seanslar.satir["tarih"].ToString();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (masktxt_tarih.Text != "  .  ." && masktxt_saat.Text != "  :" && masktxt_ucret.Text != "     tl    kr" && cmbx_salon.Text != "" && cmbx_film.Text != "")
            {
                try
                {
                    Form_Vizyon.baglantiac();
                    SqlCommand kaydet = new SqlCommand("UPDATE Seanslar SET film='" + cmbx_film.Text + "', salon='" + cmbx_salon.Text + "', ucret='" + masktxt_ucret.Text + "', saat='" + masktxt_saat.Text + "', tarih='" + masktxt_tarih.Text + "' WHERE id='" + lbl_seansid.Text + "'", Form_Vizyon.baglanti);
                    kaydet.ExecuteNonQuery();
                    kaydet = new SqlCommand("INSERT INTO SeansGecmisleri (baslik,aciklama,saat,tarih)VALUES('Seans güncelleme','" + cmbx_film.Text + " adlı filmin seans bilgileri güncellenmiştir.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_Vizyon.baglanti);
                    kaydet.ExecuteNonQuery();
                    Form_Vizyon.baglantikapa();
                    MessageBox.Show("Seans başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
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
            SeansGetir();
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

        private void SeansGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'salonlarDataSet.Salonlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.salonlarTableAdapter.Fill(this.salonlarDataSet.Salonlar);
            SeansGetir();
        }
    }
}
