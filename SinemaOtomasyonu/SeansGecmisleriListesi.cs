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
    public partial class SeansGecmisleriListesi : Form
    {
        public SeansGecmisleriListesi()
        {
            InitializeComponent();
        }

        private void SeansGecmisleriListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'seansGecmisleriDataSet.SeansGecmisleri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.seansGecmisleriTableAdapter.Fill(this.seansGecmisleriDataSet.SeansGecmisleri);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seansGecmisleriBindingSource.Filter = "baslik='" + textBox1.Text + "'";
            this.reportViewer1.RefreshReport();
        }
    }
}
