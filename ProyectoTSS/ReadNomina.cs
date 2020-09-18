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
    public partial class ReadNomina : Form
    {
        private ISO810P1Entities context;
        private EncabezadoPrint _item;
        public ReadNomina()
        {
            InitializeComponent();
            _item = null;
            context = new ISO810P1Entities();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            _item = DocumentProcess.ReadDocument();
            if (_item != null)
            {
                string moneda = context.Moneda.Find(_item.Moneda).Nombre;

                lblBanco.Text = "Banco: " + _item.CodBanco;
                lblFecha.Text = "Fecha Transmision: " + _item.Fecha_Transmision.ToString("dd-MM-yyyy");
                lblMoneda.Text = "Moneda: " + moneda;
                lblRNC.Text = "RNC: " + _item.RNC_Empresa;

                var dt = new DataTable();
                dt.Columns.Add("Tipo Documento");
                dt.Columns.Add("Documento");
                dt.Columns.Add("NSS");
                dt.Columns.Add("Salario");
                dt.Columns.Add("Salario ISR");
                dt.Columns.Add("Cuenta Bancaria");
                foreach (var i in _item.DetalleImp)
                {
                    DataRow row = dt.NewRow();

                    switch (i.TDocumento)
                    {
                        case "C": row[0] = "Cedula"; break;
                        case "P": row[0] = "Pasaporte"; break;
                        case "R": row[0] = "RNC"; break;
                        default: row[0] = "Caracter Invalido"; break;
                    }

                    row[1] = i.Documento;
                    row[2] = i.NSS;
                    row[3] = i.Salario;
                    row[4] = i.SalarioISR;
                    row[5] = i.NumeroCuenta;

                    dt.Rows.Add(row);
                }

                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                btnGuardar.Enabled = true;
            }
        }

        private void ReadNomina_Load(object sender, EventArgs e)
        {
            _item = new EncabezadoPrint();
            lblBanco.Text = "Banco: ";
            lblFecha.Text = "Fecha Transmision: ";
            lblMoneda.Text = "Moneda: ";
            lblRNC.Text = "RNC: ";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var respone = MessageBox.Show(
                buttons: MessageBoxButtons.YesNo,
                caption: "Confirme",
                text: "Desea Guardar los registros en la DB");
            if (respone == DialogResult.Yes)
            {
                bool readed = context.EncabezadoImp.AsEnumerable().Where(x => _item.Equals(x)).Any();
                if (!readed)
                {
                    try
                    {
                        var detalle = _item.DetalleImp.ToList();
                        _item.DetalleImp.Clear();
                        context.EncabezadoImp.Add(_item);
                        context.SaveChanges();
                        foreach (var it in detalle)
                        {
                            it.EncabezadoId = _item.Id;
                        }
                        context.DetalleImp.AddRange(detalle);
                        context.SaveChanges();
                        MessageBox.Show("Guardado");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Ya esta registrado");
                }

            }
        }
    }
}
