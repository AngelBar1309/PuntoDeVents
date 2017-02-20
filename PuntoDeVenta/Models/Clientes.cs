using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuntoDeVenta.Models
{
    public class Clientes
    {
        [key]
        public int clienteRfc { get; set; }
        public string nombre { get; set; } 
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string telefono { get; set; }
        public string domicilio { get; set; }
        public string correo { get; set; }

        public virtual ICollection<Venta> ventas { get; set; }
    }
}