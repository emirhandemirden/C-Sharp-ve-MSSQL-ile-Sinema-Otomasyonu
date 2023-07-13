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
    public partial class SeanslarListesiFilmeGore : Form
    {
        public SeanslarListesiFilmeGore()
        {
            InitializeComponent();
        }

        private void SeanslarListesiFilmeGore_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'seanslarDataSet.Seanslar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.seanslarTableAdapter.Fill(this.seanslarDataSet.Seanslar);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seanslarBindingSource.Filter = "film='" + textBox1.Text + "'";
            this.reportViewer1.RefreshReport();
        }
    }
}
