using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class PersonelGecmisleriListesi : Form
    {
        public PersonelGecmisleriListesi()
        {
            InitializeComponent();
        }

        private void PersonelGecmisleriListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelGecmisleriDataSet.PersonelGecmisleri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelGecmisleriTableAdapter.Fill(this.personelGecmisleriDataSet.PersonelGecmisleri);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personelGecmisleriBindingSource.Filter = "baslik='" + textBox1.Text + "'";
            this.reportViewer1.RefreshReport();
        }
    }
}
