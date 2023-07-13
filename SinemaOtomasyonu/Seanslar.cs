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
    public partial class Seanslar : Form
    {
        public Seanslar()
        {
            InitializeComponent();
        }

        int secilisatir = 0;
        public static DataRow satir;

        private void Seanslar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'salonlarDataSet.Salonlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.salonlarTableAdapter.Fill(this.salonlarDataSet.Salonlar);
            seanslarTableAdapter.Fill(seanslarDataSet.Seanslar);
        }

        private void seansOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeansEkle seansEkle = new SeansEkle();
            seansEkle.ShowDialog();
            seanslarTableAdapter.Fill(seanslarDataSet.Seanslar);
        }

        private void seansKaldırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secilisatir = gridView1.FocusedRowHandle;
            satir = gridView1.GetDataRow(secilisatir);
            SeansSil seansSil = new SeansSil();
            seansSil.ShowDialog();
            seanslarTableAdapter.Fill(seanslarDataSet.Seanslar);
        }

        private void seansGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secilisatir = gridView1.FocusedRowHandle;
            satir = gridView1.GetDataRow(secilisatir);
            SeansGuncelle seansGuncelle = new SeansGuncelle();
            seansGuncelle.ShowDialog();
            seanslarTableAdapter.Fill(seanslarDataSet.Seanslar);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            SeansGecmisleri seansGecmisleri = new SeansGecmisleri();
            seansGecmisleri.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            else if (checkBox1.Checked == false)
            {
                textBox1.Text = "";
                textBox1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
                textBox2.Focus();
            }
            else if (checkBox2.Checked == false)
            {
                textBox2.Text = "";
                textBox2.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;
                textBox3.Focus();
            }
            else if (checkBox3.Checked == false)
            {
                textBox3.Text = "";
                textBox3.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblArananalan.Text = "Film Adı:";
            txtAranan.Focus();
            txtAranan.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblArananalan.Text = "Salon:";
            txtAranan.Focus();
            txtAranan.Text = "";
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        private void txtAranan_TextChanged(object sender, EventArgs e)
        {
            HizliAra();
        }

        public void HizliAra()
        {
            try
            {
                Form_Vizyon.baglantiac();
                DataSet ds = new DataSet();
                string SorguTumKayitlar = "select * from Seanslar";
                string Sorgu1baslayan = "Select * From Seanslar where film Like'" + txtAranan.Text + "%'";
                string Sorgu1biten = "Select * From Seanslar where film Like'%" + txtAranan.Text + "'";
                string Sorgu1iceren = "Select * From Seanslar where film Like'%" + txtAranan.Text + "%'";

                string Sorgu2baslayan = "Select * From Seanslar where salon Like'" + txtAranan.Text + "%'";
                string Sorgu2biten = "Select * From Seanslar where salon Like'%" + txtAranan.Text + "'";
                string Sorgu2ceren = "Select * From Seanslar where salon Like'%" + txtAranan.Text + "%'";


                if (cmbAramaTuru.Text == "İle Başlayan")
                {
                    if (radioButton1.Checked)
                        SorguTumKayitlar = Sorgu1baslayan;
                    else
                        SorguTumKayitlar = Sorgu2baslayan;
                }
                else if (cmbAramaTuru.Text == "İle Biten")
                {
                    if (radioButton1.Checked)
                        SorguTumKayitlar = Sorgu1biten;
                    else
                        SorguTumKayitlar = Sorgu2biten;
                }
                else if (cmbAramaTuru.Text == "İçeren")
                {
                    if (radioButton1.Checked)
                        SorguTumKayitlar = Sorgu1iceren;
                    else
                        SorguTumKayitlar = Sorgu2ceren;
                }

                SqlDataAdapter da = new SqlDataAdapter(SorguTumKayitlar, Form_Vizyon.baglanti);
                da.Fill(ds, "Seanslar");
                gridControl1.DataSource = ds.Tables["Seanslar"];
                Form_Vizyon.baglantikapa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void KayitAra()
        {
            try
            {
                Form_Vizyon.baglantiac();
                DataSet ds = new DataSet();
                string SorguTumKayitlar = "select * from Seanslar";
                string Sorgu1 = "Select * From Seanslar where film='" + textBox1.Text + "'";
                string Sorgu2 = "Select * From Seanslar where salon='" + textBox2.Text + "'";
                string Sorgu3 = "select * from Seanslar where tarih='" + textBox3.Text + "'";

                string Sorgu12 = "Select * From Seanslar where film='" + textBox1.Text + "' And salon='" + textBox2.Text + "'";
                string Sorgu13 = "Select * From Seanslar where film='" + textBox1.Text + "' And tarih='" + textBox3.Text + "'";
                string Sorgu23 = "Select * From Seanslar where salon='" + textBox2.Text + "' And tarih='" + textBox3.Text + "'";

                string Sorgu123 = "Select * From Seanslar where film='" + textBox1.Text + "' And salon='" + textBox2.Text + "' And tarih='" + textBox3.Text + "'";

                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                    SorguTumKayitlar = Sorgu123;
                else if (checkBox2.Checked && checkBox3.Checked)
                    SorguTumKayitlar = Sorgu23;
                else if (checkBox1.Checked && checkBox3.Checked)
                    SorguTumKayitlar = Sorgu13;
                else if (checkBox1.Checked && checkBox2.Checked)
                    SorguTumKayitlar = Sorgu12;
                else if (checkBox1.Checked)
                    SorguTumKayitlar = Sorgu1;
                else if (checkBox2.Checked)
                    SorguTumKayitlar = Sorgu2;
                else if (checkBox3.Checked)
                    SorguTumKayitlar = Sorgu3;


                SqlDataAdapter da = new SqlDataAdapter(SorguTumKayitlar, Form_Vizyon.baglanti);
                da.Fill(ds, "Seanslar");
                gridControl1.DataSource = ds.Tables["Seanslar"];
                Form_Vizyon.baglantikapa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
