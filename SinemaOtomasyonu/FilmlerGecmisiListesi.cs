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
    public partial class FilmlerGecmisiListesi : Form
    {
        public FilmlerGecmisiListesi()
        {
            InitializeComponent();
        }

        private void FilmlerGecmisiListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'filmGecmisleriDataSet.FilmGecmisleri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmGecmisleriTableAdapter.Fill(this.filmGecmisleriDataSet.FilmGecmisleri);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filmGecmisleriBindingSource.Filter = "baslik='" + textBox1.Text + "'";
            this.reportViewer1.RefreshReport();
        }
    }
}
