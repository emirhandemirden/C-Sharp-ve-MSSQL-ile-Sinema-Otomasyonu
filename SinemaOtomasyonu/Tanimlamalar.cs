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
    public partial class Tanimlamalar : Form
    {
        public Tanimlamalar()
        {
            InitializeComponent();
        }

        public static string satir;
        public static string id;
        public static string ad;
        public static string kisisayisi;

        private void Tanimlamalar_Load(object sender, EventArgs e)
        {
            filmTurleriTableAdapter.Fill(filmTurleriDataSet.FilmTurleri);
            biletTurleriTableAdapter.Fill(biletTurleriDataSet.BiletTurleri);
            salonlarGetir();
        }

        private void salonlarGetir()
        {
            lst_salonlar.Items.Clear();
            try
            {
                Form_Vizyon.baglantiac();
                SqlCommand al = new SqlCommand("SELECT * FROM Salonlar",Form_Vizyon.baglanti);
                SqlDataReader verioku = al.ExecuteReader();
                while (verioku.Read())
                {
                    string[] satir = { verioku["id"].ToString(), verioku["ad"].ToString(), verioku["kisisayisi"].ToString() };
                    lst_salonlar.Items.Add(new ListViewItem(satir));
                }
                verioku.Close();
                Form_Vizyon.baglantikapa();
            }
            catch (Exception hata)
            { MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FilmTurEkle filmTurEkle = new FilmTurEkle();
            filmTurEkle.ShowDialog();
            filmTurleriTableAdapter.Fill(filmTurleriDataSet.FilmTurleri);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            satir = lst_filmturleri.GetItemText(lst_filmturleri.SelectedItem);
            id = lst_filmturleri.SelectedValue.ToString();
            FilmTurSil filmTurSil = new FilmTurSil();
            filmTurSil.ShowDialog();
            filmTurleriTableAdapter.Fill(filmTurleriDataSet.FilmTurleri);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            satir = lst_filmturleri.GetItemText(lst_filmturleri.SelectedItem);
            id = lst_filmturleri.SelectedValue.ToString();
            FilmTurGuncelle filmTurGuncelle = new FilmTurGuncelle();
            filmTurGuncelle.ShowDialog();
            filmTurleriTableAdapter.Fill(filmTurleriDataSet.FilmTurleri);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            BiletTurEkle biletTurEkle = new BiletTurEkle();
            biletTurEkle.ShowDialog();
            biletTurleriTableAdapter.Fill(biletTurleriDataSet.BiletTurleri);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            satir = lst_biletturleri.GetItemText(lst_biletturleri.SelectedItem);
            id = lst_biletturleri.SelectedValue.ToString();
            BiletTurSil biletTurSil = new BiletTurSil();
            biletTurSil.ShowDialog();
            biletTurleriTableAdapter.Fill(biletTurleriDataSet.BiletTurleri);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            satir = lst_biletturleri.GetItemText(lst_biletturleri.SelectedItem);
            id = lst_biletturleri.SelectedValue.ToString();
            BiletTurGuncelle biletTurGuncelle = new BiletTurGuncelle();
            biletTurGuncelle.ShowDialog();
            biletTurleriTableAdapter.Fill(biletTurleriDataSet.BiletTurleri);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            SalonEkle salonEkle = new SalonEkle();
            salonEkle.ShowDialog();
            salonlarGetir();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            id = lst_salonlar.SelectedItems[0].SubItems[0].Text;
            ad = lst_salonlar.SelectedItems[0].SubItems[1].Text;
            SalonSil salonSil = new SalonSil();
            salonSil.ShowDialog();
            salonlarGetir();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            id = lst_salonlar.SelectedItems[0].SubItems[0].Text;
            ad = lst_salonlar.SelectedItems[0].SubItems[1].Text;
            kisisayisi = lst_salonlar.SelectedItems[0].SubItems[2].Text;
            SalonGuncelle salonGuncelle = new SalonGuncelle();
            salonGuncelle.ShowDialog();
            salonlarGetir();
        }
    }
}
