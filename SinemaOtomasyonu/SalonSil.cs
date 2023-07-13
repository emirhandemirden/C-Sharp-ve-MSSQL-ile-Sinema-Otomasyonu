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
    public partial class SalonSil : Form
    {
        public SalonSil()
        {
            InitializeComponent();
        }

        private void salonGetir()
        {
            lbl_salonid.Text = Tanimlamalar.id;
            txt_ad.Text = Tanimlamalar.ad;
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show(txt_ad.Text + " adlı salonu silmek istediğinize emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == cevap)
            {
                try
                {
                    Form_Vizyon.baglantiac();
                    SqlCommand sil = new SqlCommand("DELETE FROM Salonlar WHERE id='" + lbl_salonid.Text + "'", Form_Vizyon.baglanti);
                    sil.ExecuteNonQuery();
                    Form_Vizyon.baglantikapa();
                    MessageBox.Show("Salon silindi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception hata)
                { MessageBox.Show("Bir hata ile karşılaşıldı.\nHata:" + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void SalonSil_Load(object sender, EventArgs e)
        {
            salonGetir();
        }
    }
}
