using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PuntoDeVenta.Models
{
    public class Productos
    {
        [Key]
        public int productoID { get; set; }

        public string nombreProducto { get; set; }
        public decimal stock { get; set; }
        public decimal precio { get; set; }
        public decimal cantidad { get; set; }
        public string categoria { get; set; }

        public virtual ICollection<Compras> compras { get; set; }

        public virtual ICollection<VentaProductos> ventaProductos { get; set; }
    }
}