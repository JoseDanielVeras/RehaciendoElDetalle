using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RehaciendoElDetalle.Entidades
{
    public class Roles
    {
        [Key]
        public int RolId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Descripcion { get; set; }
        public bool EsActivo { get; set; }

        [ForeignKey("RolId")]
        public virtual List<RolesDetalle> RolesDetalle { get; set; }

        public Roles()
        {
            RolId = 0;
            FechaCreacion = DateTime.Now;
            EsActivo = false;
            RolesDetalle = new List<RolesDetalle>();
        }
    }
}
