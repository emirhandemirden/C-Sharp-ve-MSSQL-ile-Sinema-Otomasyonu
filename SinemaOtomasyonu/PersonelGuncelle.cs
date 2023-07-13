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
    public partial class PersonelGuncelle : Form
    {
        public PersonelGuncelle()
        {
            InitializeComponent();
        }

        private void PersonelGetir()
        {
            lbl_personelid.Text = Personeller.satir["id"].ToString();
            txt_ad.Text = Personeller.satir["ad"].ToString();
            masktxt_tarih.Text = Personeller.satir["dogum"].ToString();
            masktxt_tel.Text = Personeller.satir["telefon"].ToString();
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void temizle()
        {
            PersonelGetir();
            masktxt_tarih.BackColor = Color.White;
            masktxt_tarih.ForeColor = Color.Black;
            masktxt_tarih.BackColor = Color.White;
            masktxt_tarih.ForeColor = Color.Black;
            masktxt_tel.BackColor = Color.White;
            masktxt_tel.ForeColor = Color.Black;
            txt_ad.BackColor = Color.White;
            txt_ad.ForeColor = Color.Black;
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (masktxt_tarih.Text != "  .  ." && masktxt_tel.Text != "(   )    -   " && txt_ad.Text != "")
            {
                try
                {
                    Form_Vizyon.baglantiac();
                    SqlCommand kaydet = new SqlCommand("UPDATE Personeller SET ad='" + txt_ad.Text + "', dogum='" + masktxt_tarih.Text + "', telefon='" + masktxt_tel.Text + "' WHERE id='" + lbl_personelid.Text + "'", Form_Vizyon.baglanti);
                    kaydet.ExecuteNonQuery();
                    kaydet = new SqlCommand("INSERT INTO PersonelGecmisleri (baslik,aciklama,saat,tarih)VALUES('Personel güncelleme','" + txt_ad.Text + " adlı personel bilgileri güncellenmiştir.','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "')", Form_Vizyon.baglanti);
                    kaydet.ExecuteNonQuery();
                    Form_Vizyon.baglantikapa();
                    temizle();
                    MessageBox.Show("Personel başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception hata)
                { MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                if (masktxt_tel.Text == "(   )    -   ")
                {
                    masktxt_tel.BackColor = Color.DarkRed;
                    masktxt_tel.ForeColor = Color.White;
                    masktxt_tel.Focus();
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

        private void PersonelGuncelle_Load(object sender, EventArgs e)
        {
            PersonelGetir();
        }
    }
}
