using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtroRegistroCompleto.Entidades
{
    public class Roles
    {
        [Key]
        public int RolId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Descripcion { get; set; }

        public Roles()
        {
            RolId = 0;
            FechaCreacion = DateTime.Now;

            RolesDetalle = new List<RolesDetalle>();
        }

        [ForeignKey("RolId")]
        public virtual List<RolesDetalle> RolesDetalle { get; set; }
    }
}
