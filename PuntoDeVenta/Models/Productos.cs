using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuntoDeVenta.Models
{
    public class Productos
    {
        public int productoID { get; set; }
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        
    }
}