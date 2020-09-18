using ProyectoTSS.Models;
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
    public partial class DetalleNuevoFm : Form
    {
        public bool valid { get; set; }
        public DetalleImp Item { get; internal set; }

        public DetalleNuevoFm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valid = false;
            this.Hide();

        }

        private void btnOpenNomina_Click(object sender, EventArgs e)
        {
            Item.Salario = decimal.Parse(txtSalario.Text.Trim());
            Item.SalarioISR = decimal.Parse(txtSISR.Text.Trim());
            Item.Documento = txtDocumento.Text.Trim();
            Item.NSS = maskedTextBox1.Text.Trim();
            Item.NumeroCuenta = TxtCuetna.Text.Trim();


            valid = true;
            this.Hide();
        }

        private void cbxTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item.TDocumento = cbxTD.SelectedItem.ToString().Substring(0, 1);

        }

        private void KeyPressOnlyNumber(object sender, KeyPressEventArgs e)
        {

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            btnOpenNomina.Enabled =
                txtDocumento.Text.Length > 0 &&
                txtSalario.Text.Length > 0 &&
                txtSISR.Text.Length > 0 &&
                TxtCuetna.Text.Length > 0 &&
                cbxTD.SelectedIndex > -1 &&
                maskedTextBox1.MaskCompleted;
        }
    }
}
