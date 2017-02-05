using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuntoDeVenta.Models
{
    public class Ventas
    {
        public int ventasID { get; set; }

        public DateTime fechaVenta { get; set; }
        public int catidadDeVenta { get; set; }

        //public int clienteID { get; set; }

        public int productoID { get; set; }
        public ICollection<Productos> productos { get; set; }
        public virtual Clientes cliente { get; set; }
    }
}