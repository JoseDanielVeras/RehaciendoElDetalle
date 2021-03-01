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

        [ForeignKey("PermisoID")]
        public virtual List<RolesDetalle> RolesDetalles { get; set; }
    }
}
