using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuntoDeVenta.Models
{
    public class Venta
    {
        public int ventaID { get; set; }
        public decimal costo { get; set; }
        public DateTime fecha { get; set; }

        public int clienteRfc { get; set; }
        public virtual Clientes clientes { get; set; }

        public virtual ICollection<VentaProductos> ventaProductos { get; set; }
    }

}