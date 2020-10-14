using System;

namespace CaroApp.Models
{
    public class InfoSalida
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public int ClaveContable { get; set; }
        public int Cuenta { get; set; }
        public decimal Importe { get; set; }
        public int Division { get; set; }
        public string Texto { get; set; }
        public DateTime Fecha { get; set; }

    }
}
