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
    public partial class BiletTurSil : Form
    {
        public BiletTurSil()
        {
            InitializeComponent();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show(txt_tur.Text + " adlı bilet türünü silmek istediğinize emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == cevap)
            {
                try
                {
                    Form_Vizyon.baglantiac();
                    SqlCommand sil = new SqlCommand("DELETE FROM BiletTurleri WHERE id='" + lbl_turid.Text + "'", Form_Vizyon.baglanti);
                    sil.ExecuteNonQuery();
                    Form_Vizyon.baglantikapa();
                    MessageBox.Show("Tür silindi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception hata)
                { MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void turGetir()
        {
            lbl_turid.Text = Tanimlamalar.id;
            txt_tur.Text = Tanimlamalar.satir;
        }

        private void BiletTurSil_Load(object sender, EventArgs e)
        {
            turGetir();
        }
    }
}
