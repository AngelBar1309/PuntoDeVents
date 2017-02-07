using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PuntoDeVenta.Models
{
    public class Compras
    {
        [Key]
        public int compraID { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime fecha { get; set; }


        public int productoID { get; set; }
        public virtual Productos productos { get; set; }

        public string proveedorRfc { get; set; }
        public virtual Proveedores proveedores { get; set; }
    }
}