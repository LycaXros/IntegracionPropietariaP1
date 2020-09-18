using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTSS.Models
{
    public class DetallePrint : DetalleImp
    {
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("D ")
               .Append(TDocumento)
               .Append(Documento.PadRight(15))
               .Append(NSS.PadRight(8))
               .Append(Salario.ToString("0.00").PadRight(10))
               .Append(SalarioISR.ToString("0.00").PadRight(10))
               .Append(NumeroCuenta.ToString().PadRight(20));

            return str.ToString();
        }
    }
    public class EncabezadoPrint : EncabezadoImp
    {
        public List<DetallePrint> Detalles { get; set; }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("E ")
               .Append(this.Moneda.PadRight(3))
               .Append(Fecha_Transmision.ToString("yyyyMMdd"))
               .Append(CodBanco.PadRight(3))
               .Append(RNC_Empresa.PadRight(11))
               .Append(Fecha_Transmision.ToString("MM/yyyy"));

            return str.ToString();
        }
        public bool Equals(EncabezadoImp obj)
        {
            return this.Moneda == obj.Moneda &&
                     this.Fecha_Transmision.Equals(obj.Fecha_Transmision) &&
                     this.RNC_Empresa.Equals(obj.RNC_Empresa) &&
                     this.CodBanco.Equals(obj.CodBanco);
        }

        public bool hasData { get; set; } = false;
        public Summary SummaryData { get; set; }

    }
    public class Summary
    {
        public decimal TotalM { get; set; }
        public int TotalDetalle { get; set; }
    }
    public static class DocumentProcess
    {
        private static string folder = "";
        public static void Print(EncabezadoImp item)
        {
            folder = null;
            decimal total = 0;
            StringBuilder printer = new StringBuilder();

            EncabezadoPrint ep = new EncabezadoPrint()
            {
                RNC_Empresa = item.RNC_Empresa,
                CodBanco = item.CodBanco,
                Moneda = item.Moneda,
                MonedaEntity = item.MonedaEntity,
                Detalles = Casting(item.DetalleImp.ToList()),
                Fecha_Transmision = item.Fecha_Transmision,
                DetalleImp = item.DetalleImp,
                MesPago = item.MesPago,
                Id = item.Id
            };

            printer.AppendLine(ep.ToString());

            foreach (DetallePrint i in ep.Detalles)
            {
                printer.AppendLine(i.ToString());
                total += i.SalarioISR;
            }

            printer.Append("S ")
                .Append(ep.DetalleImp.Count.ToString().PadRight(5))
                .Append(total.ToString().PadRight(10));

            Console.WriteLine(printer.ToString());

            var dir = new FolderBrowserDialog();


            if (dir.ShowDialog() == DialogResult.OK)
                folder = dir.SelectedPath;
            else
                folder = string.Empty;

            // If the file name is not an empty string open it for saving.
            if (folder != "")
            {
                string filename = folder + $"\\file{DateTime.Now.ToString("yyyyMMddHHmmss")}.txt";
                // Saves the Image via a FileStream created by the OpenFile method.
                StreamWriter fs = File.AppendText(filename);
                fs.WriteLine(printer.ToString());

                fs.Close();
                MessageBox.Show("Archivo Impreso!!!!!!!!!!!!!!!!!");
            }
        }

        private static List<DetallePrint> Casting(List<DetalleImp> lists)
        {
            List<DetallePrint> ls = new List<DetallePrint>();

            foreach (var item in lists)
            {
                DetallePrint it = new DetallePrint
                {
                    Documento = item.Documento,
                    EncabezadoId = item.EncabezadoId,
                    EncabezadoImp = item.EncabezadoImp,
                    Id = item.Id,
                    NSS = item.NSS,
                    NumeroCuenta = item.NumeroCuenta,
                    Salario = item.Salario,
                    SalarioISR = item.SalarioISR,
                    TDocumento = item.TDocumento
                };
                ls.Add(it);
            }
            return ls;
        }

        public static EncabezadoPrint ReadDocument()
        {

            try
            {
                EncabezadoPrint imp = new EncabezadoPrint();
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.InitialDirectory = folder;
                // Set filter options and filter index.
                openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;

                //openFileDialog1.Multiselect = true;

                // Call the ShowDialog method to show the dialog box.
                openFileDialog1.ShowDialog();

                string archivo = openFileDialog1.FileName;

                if (archivo.Trim().Length > 0)
                    // Open the selected file to read.

                    using (StreamReader sr = new StreamReader(archivo))
                    {
                        string line = null;
                        List<DetalleImp> dets = new List<DetalleImp>();
                        EncabezadoPrint enc = new EncabezadoPrint();
                        Summary sm = new Summary();
                        while ((line = sr.ReadLine()) != null)
                        {
                            string sub = line.Substring(0, 2).Trim();
                            switch (sub)
                            {
                                case "E": enc = LlenarEncabezad(line); break;
                                case "D": dets.Add(LlenarDetalle(line)); break;
                                case "S":
                                    sm.TotalDetalle = int.Parse(line.Substring(2, 5).Trim());
                                    sm.TotalM = decimal.Parse(line.Substring(7, 10).Trim());
                                    break;
                                default:
                                    Console.WriteLine("Error Caractaer");
                                    //throw new ArgumentNullException("Linea con caracteres no validos"); 
                                    continue;
                            }
                        }

                        if (!imp.hasData) { imp = enc; imp.hasData = true; }
                        if (dets.Count() > 0) imp.DetalleImp = dets;
                        imp.SummaryData = sm;

                    }

                return imp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private static EncabezadoPrint LlenarEncabezad(string line)
        {

            //.Append(this.Moneda.PadRight(3))
            //.Append(Fecha_Transmision.ToString("yyyyMMdd"))
            //.Append(CodBanco.PadRight(3))
            //.Append(RNC_Empresa.PadRight(11))
            //.Append(Fecha_Transmision.ToString("MM/yyyy"));
            int start = 2;
            EncabezadoPrint enc = new EncabezadoPrint();
            enc.Moneda = line.Substring(start, 3).Trim(); start += 3;

            string date = line.Substring(start, 8).ToString().Trim();

            CultureInfo provider = CultureInfo.InvariantCulture;
            enc.Fecha_Transmision = DateTime.ParseExact(date, "yyyyMMdd", provider); start += 8;
            enc.CodBanco = line.Substring(start, 3).Trim(); start += 3;
            enc.RNC_Empresa = line.Substring(start, 11).Trim();


            return enc;
        }

        private static DetalleImp LlenarDetalle(string line)
        {
            int start = 2;
            DetalleImp detalle = new DetalleImp();

            //str.Append("D ")
            //   .Append(TDocumento)
            //   .Append(Documento.PadRight(15))
            //   .Append(NSS.PadRight(8))
            //   .Append(Salario.ToString().PadRight(10))
            //   .Append(SalarioISR.ToString().PadRight(10))
            //   .Append(NumeroCuenta.ToString().PadRight(20));

            detalle.TDocumento = line.Substring(start, 1).Trim(); start += 1;
            detalle.Documento = line.Substring(start, 15).Trim(); start += 15;
            detalle.NSS = line.Substring(start, 8).Trim(); start += 8;
            detalle.Salario = decimal.Parse(line.Substring(start, 10).Trim()); start += 10;
            detalle.SalarioISR = decimal.Parse(line.Substring(start, 10).Trim()); start += 10;
            detalle.NumeroCuenta = line.Substring(start, 20).Trim();

            return detalle;
        }
    }
}
