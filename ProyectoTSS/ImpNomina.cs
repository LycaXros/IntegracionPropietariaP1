using ProyectoTSS.Models;
using System;
using System.Data.Entity;
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
    public partial class ImpNomina : Form
    {
        private ISO810P1Entities context;
        private EncabezadoPrint _item;
        private string selectedModneda;
        private DataTable dt;
        public ImpNomina()
        {
            InitializeComponent();
            context = new ISO810P1Entities();
            _item = new EncabezadoPrint();
            
            dt = null;

        }

        private void ImpNomina_Load(object sender, EventArgs e)
        {

            var list = context.Moneda
                .Select(x => new { Key = x.Codigo, Value = x.Nombre })
                .ToList();

            cbxMoneda.DisplayMember = "Value";
            cbxMoneda.ValueMember = "Key";
            cbxMoneda.DataSource = list;
            cbxMoneda.Refresh();

            dt = new DataTable();
            dt.Columns.Add("Tipo Documento");
            dt.Columns.Add("Documento");
            dt.Columns.Add("NSS");
            dt.Columns.Add("Salario");
            dt.Columns.Add("Salario ISR");
            dt.Columns.Add("Cuenta Bancaria");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (var m = new ISO810P1Entities())
            //{
            //    EncabezadoImp imp = m.EncabezadoImp
            //        .Include(x => x.DetalleImp)
            //        .Include(x => x.MonedaEntity)
            //        .FirstOrDefault(x => x.Id == 1);
            //    if (imp == null) return;
            //    DocumentProcess.Print(imp);
            //}

            _item.Fecha_Transmision = DateTime.Now;
            _item.Moneda = selectedModneda;
            _item.MesPago = DateTime.Now.Month;
            _item.RNC_Empresa = textBox1.Text.Trim();
            _item.CodBanco = textBox2.Text.Trim();
            DocumentProcess.Print(_item);
        }

        private void cbxMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedModneda = (string)cbxMoneda.SelectedValue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetalleImp di = new DetalleImp();
            var frm = new DetalleNuevoFm
            {
                valid = false,
                Item = di
            };

            frm.ShowDialog();
            this.Show();
            if (frm.valid)
            {
                _item.DetalleImp.Add(di);
                button1.Enabled = true;

                DataRow row = dt.NewRow();

                switch (di.TDocumento)
                {
                    case "C": row[0] = "Cedula"; break;
                    case "P": row[0] = "Pasaporte"; break;
                    case "R": row[0] = "RNC"; break;
                    default: row[0] = "Caracter Invalido"; break;
                }

                row[1] = di.Documento;
                row[2] = di.NSS;
                row[3] = di.Salario;
                row[4] = di.SalarioISR;
                row[5] = di.NumeroCuenta;

                dt.Rows.Add(row);

                dataGridView1.Refresh();
            }

            frm.Dispose();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled =
                textBox1.Text.Length > 0 &&
                textBox2.Text.Length > 0 &&
                cbxMoneda.Text.Length > 0;
        }
    }
}
