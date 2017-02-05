using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuntoDeVenta.Models
{
    public class Clientes
    {
        public int clienteID { get; set; }

        public string nombre { get; set; }

        public string apellidos { get; set; }

        public string direccion { get; set; }

        public string telefono { get; set; }

        public int ventasID { get; set; }
        public ICollection<Ventas> venta { get; set; }
    }
   
}