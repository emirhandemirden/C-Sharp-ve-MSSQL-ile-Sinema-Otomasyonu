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
    public partial class FilmGuncelle : Form
    {
        public FilmGuncelle()
        {
            InitializeComponent();
        }

        private void filmGetir()
        {
            lbl_filmid.Text = Filmler.row["id"].ToString();
            txt_ad.Text = Filmler.row["ad"].ToString();
            masktxt_tarih.Text = Filmler.row["vizyontarih"].ToString();
            masktxt_sure.Text = Filmler.row["sure"].ToString();
            cmbx_tur.Text = Filmler.row["tur"].ToString();
            txt_yonetmen.Text = Filmler.row["yonetmen"].ToString();
            txt_oyuncular.Text = Filmler.row["oyuncular"].ToString();
            rtxt_ozet.Text = Filmler.row["ozet"].ToString();
            txt_link.Text = Filmler.row["fragmanlink"].ToString();
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void temizle()
        {
            filmGetir();
            txt_link.BackColor = Color.White;
            txt_link.ForeColor = Color.Black;
            rtxt_ozet.BackColor = Color.White;
            rtxt_ozet.ForeColor = Color.Black;
            txt_oyuncular.BackColor = Color.White;
            txt_oyuncular.ForeColor = Color.Black;
            txt_yonetmen.BackColor = Color.White;
            txt_yonetmen.ForeColor = Color.Black;
            cmbx_tur.BackColor = Color.White;
            cmbx_tur.ForeColor = Color.Black;
            masktxt_sure.BackColor = Color.White;
            masktxt_sure.ForeColor = Color.Black;
            masktxt_tarih.BackColor = Color.White;
            masktxt_tarih.ForeColor = Color.Black;
            txt_ad.BackColor = Color.White;
            txt_ad.ForeColor = Color.Black;
            txt_ad.Focus();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text != "" && masktxt_tarih.Text != "  .  ." && masktxt_sure.Text != " s   dk" && cmbx_tur.Text != "" && txt_yonetmen.Text != "" && txt_oyuncular.Text != "" && rtxt_ozet.Text != "" && txt_link.Text != "")
            {
                try
                {
                    Form_Vizyon.baglantiac();
                    SqlCommand guncelle = new SqlCommand("UPDATE Filmler SET ad='" + txt_ad.Text + "',vizyontarih='" + masktxt_tarih.Text + "',sure='" + masktxt_sure.Text + "',tur='" + cmbx_tur.Text + "',yonetmen='" + txt_yonetmen.Text + "',oyuncular='" + txt_oyuncular.Text + "',ozet='" + rtxt_ozet.Text + "',fragmanlink='" + txt_link.Text + "' WHERE id='" + lbl_filmid.Text + "'", Form_Vizyon.baglanti);
                    guncelle.ExecuteNonQuery();
                    SqlCommand kaydet = new SqlCommand("INSERT INTO FilmGecmisleri (baslik,aciklama,saat,tarih)VALUES('Film güncelleme','" + txt_ad.Text + " adlı film verileri güncellendi.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_Vizyon.baglanti);
                    kaydet.ExecuteNonQuery();
                    Form_Vizyon.baglantikapa();
                    MessageBox.Show("Film başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception hata)
                { MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                if (txt_link.Text == "")
                {
                    txt_link.BackColor = Color.DarkRed;
                    txt_link.ForeColor = Color.White;
                    txt_link.Focus();
                }
                if (rtxt_ozet.Text == "")
                {
                    rtxt_ozet.BackColor = Color.DarkRed;
                    rtxt_ozet.ForeColor = Color.White;
                    rtxt_ozet.Focus();
                }
                if (txt_oyuncular.Text == "")
                {
                    txt_oyuncular.BackColor = Color.DarkRed;
                    txt_oyuncular.ForeColor = Color.White;
                    txt_oyuncular.Focus();
                }
                if (txt_yonetmen.Text == "")
                {
                    txt_yonetmen.BackColor = Color.DarkRed;
                    txt_yonetmen.ForeColor = Color.White;
                    txt_yonetmen.Focus();
                }
                if (cmbx_tur.Text == "")
                {
                    cmbx_tur.BackColor = Color.DarkRed;
                    cmbx_tur.ForeColor = Color.White;
                    cmbx_tur.Focus();
                }
                if (masktxt_sure.Text == " s   dk")
                {
                    masktxt_sure.BackColor = Color.DarkRed;
                    masktxt_sure.ForeColor = Color.White;
                    masktxt_sure.Focus();
                }
                if (masktxt_tarih.Text == "  .  .")
                {
                    masktxt_tarih.BackColor = Color.DarkRed;
                    masktxt_tarih.ForeColor = Color.White;
                    masktxt_tarih.Focus();
                }
                if (txt_ad.Text == "")
                {
                    txt_ad.BackColor = Color.DarkRed;
                    txt_ad.ForeColor = Color.White;
                    txt_ad.Focus();
                }
            }
        }

        private void FilmGuncelle_Load(object sender, EventArgs e)
        {
            filmTurleriTableAdapter.Fill(filmTurleriDataSet.FilmTurleri);
            filmGetir();
        }
    }
}
