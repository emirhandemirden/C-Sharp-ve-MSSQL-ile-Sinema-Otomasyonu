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
    public partial class BiletlerGecmisiListesi : Form
    {
        public BiletlerGecmisiListesi()
        {
            InitializeComponent();
        }

        private void BiletlerGecmisiListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'biletGecmisleriDataSet.BiletGecmisleri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.biletGecmisleriTableAdapter.Fill(this.biletGecmisleriDataSet.BiletGecmisleri);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            biletGecmisleriBindingSource.Filter = "baslik='" + textBox1.Text + "'";
            this.reportViewer1.RefreshReport();
        }
    }
}
