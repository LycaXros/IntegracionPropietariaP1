//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoTSS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleImp
    {
        public int Id { get; set; }
        public int EncabezadoId { get; set; }
        public string TDocumento { get; set; }
        public string Documento { get; set; }
        public string NSS { get; set; }
        public decimal Salario { get; set; }
        public decimal SalarioISR { get; set; }
        public string NumeroCuenta { get; set; }
    
        public virtual EncabezadoImp EncabezadoImp { get; set; }
    }
}
