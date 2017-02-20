using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PuntoDeVenta.Models
{
    public class Proveedores
    {
        [Key]
        public string proveedorRfc { get; set; }
        public string nombreProveedora { get; set; }
        public string domicilio { get; set; }
        public string telefono { get; set; }

        public virtual ICollection<Compras> compras { get; set; }
    }
}