using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuntoDeVenta.Models
{
    public class Proveedores
    {
        public int proveedorID { get; set; }

        public string nombre { get; set; }
        public string domicilio { get; set; }
        public string telefono { get; set; }

        public ICollection<Compras> compras { get; set; }
    }
}