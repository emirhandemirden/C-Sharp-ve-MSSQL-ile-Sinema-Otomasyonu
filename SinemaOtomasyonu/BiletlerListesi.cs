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
    public partial class BiletlerListesi : Form
    {
        public BiletlerListesi()
        {
            InitializeComponent();
        }

        private void BiletlerListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'biletlerDataSet.Biletler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.biletlerTableAdapter.Fill(this.biletlerDataSet.Biletler);

            this.reportViewer1.RefreshReport();
        }
    }
}
