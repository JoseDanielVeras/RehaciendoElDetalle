using Microsoft.EntityFrameworkCore;
using RehaciendoElDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RehaciendoElDetalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Permisos> Permisos { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<RolesDetalle> RolesDetalles { get; set; }
        public DbSet<Usuarios> Usuarios { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA/GestionUsuarios.Db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Permisos>().HasData(
                new Permisos() { PermisoId = 1, Descripcion = "Administrador" },
                new Permisos() { PermisoId = 2, Descripcion = "Programador"},
                new Permisos() { PermisoId = 3, Descripcion = "Diseñador"}
                );
        }
    }
}
