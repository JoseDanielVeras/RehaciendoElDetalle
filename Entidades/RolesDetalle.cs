﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtroRegistroCompleto.Entidades
{
    public class RolesDetalle
    {
        [Key]
        public int RolDetalleId { get; set; }
        public int RolId { get; set; }
        public int PermisoId { get; set; }
        public bool EsAsignado { get; set; }

        public RolesDetalle()
        {
            RolDetalleId = 0;
            RolId = 0;
            PermisoId = 0;
            EsAsignado = true;
        }

        public RolesDetalle(int rolId, int permisoId, bool esAsignado)
        {
            RolDetalleId = 0;
            RolId = rolId;
            PermisoId = permisoId;
            EsAsignado = esAsignado;
        }
    }
}
