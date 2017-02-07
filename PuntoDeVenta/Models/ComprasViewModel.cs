using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PuntoDeVenta.Models
{
    public class ComprasViewModel
    {
        

        //Producto
        public string nombreProducto { get; set; }
        public decimal stock { get; set; }
        public decimal precio { get; set; }
        public decimal cantidad { get; set; }
        public string categoria { get; set; }

        //Compra
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime fecha { get; set; }
        public int productoID { get; set; }
        public string proveedorRfc { get; set; }
    }
}