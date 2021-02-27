using Microsoft.EntityFrameworkCore;
using OtroRegistroCompleto.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace OtroRegistroCompleto.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<RolesDetalle> RolesDetalles { get; set; }
        public DbSet<Permisos> Permisos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = GestionUsuarios.Db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Permisos>().HasData(
                new Permisos() { PermisoId = 1, Descripcion = "Descuenta" },
                new Permisos() { PermisoId = 2, Descripcion = "Vende" },
                new Permisos() { PermisoId = 3, Descripcion = "Cobra" });
        }
    }
}
