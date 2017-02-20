using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuntoDeVenta.Models
{
    public class VentaProductos
    {
        public int ventaProductosID { get; set; }

        public int ventaID { get; set; }
        public virtual Venta ventas { get; set; }

        public int productoID { get; set; }
        public virtual Productos productos { get; set; }
    }
}