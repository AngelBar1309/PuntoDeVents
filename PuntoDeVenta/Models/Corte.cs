using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuntoDeVenta.Models
{
    public class Corte
    {
        public int corteID { get; set; }

        public DateTime fechaCorte { get; set; }

        public decimal monto { get; set; }

        public ICollection<Ventas> ventas { get; set; }
    }
}