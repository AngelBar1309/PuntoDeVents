using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuntoDeVenta.Models
{
    public class Compras
    {
        public int comprasID { get; set; }

        public DateTime fechaCompra { get; set; }

        public int proveedorID { get; set; }

        public int productoID { get; set; }


    }
}