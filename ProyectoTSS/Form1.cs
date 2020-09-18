using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenNomina_Click(object sender, EventArgs e)
        {
            ImpNomina frm = new ImpNomina();

            this.Hide();
            frm.ShowDialog();
            this.Show();
            frm.Dispose();
        }

        private void btnOpenRead_Click(object sender, EventArgs e)
        {
            ReadNomina frm = new ReadNomina();

            this.Hide();
            frm.ShowDialog();
            this.Show();
            frm.Dispose();
        }
    }
}
