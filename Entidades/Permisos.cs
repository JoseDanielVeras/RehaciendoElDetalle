using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RehaciendoElDetalle.Entidades
{
    public class Permisos
    {
        [Key]
        public int PermisoId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Descripcion { get; set; }
        public int VecesAsignado { get; set; }

        [ForeignKey("PermisoId")]
        public virtual List<RolesDetalle> RolesDetalle { get; set; }
    }
}
