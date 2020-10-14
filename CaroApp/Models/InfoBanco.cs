using System;

namespace CaroApp.Models
{
    public class InfoBanco
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Comprobante { get; set; }
        public decimal Importe { get; set; }
        public string Descripcion { get; set; }

    }
}
