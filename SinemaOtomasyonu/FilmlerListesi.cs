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
    public partial class FilmlerListesi : Form
    {
        public FilmlerListesi()
        {
            InitializeComponent();
        }

        private void FilmlerListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'filmlerDataSet.Filmler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmlerTableAdapter.Fill(this.filmlerDataSet.Filmler);

            this.reportViewer1.RefreshReport();
        }
    }
}
