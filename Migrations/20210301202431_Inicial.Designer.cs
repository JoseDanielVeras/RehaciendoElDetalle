﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RehaciendoElDetalle.DAL;

namespace RehaciendoElDetalle.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210301202431_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("RehaciendoElDetalle.Entidades.Permisos", b =>
                {
                    b.Property<int>("PermisoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.Property<int>("VecesAsignado")
                        .HasColumnType("INTEGER");

                    b.HasKey("PermisoId");

                    b.ToTable("Permisos");

                    b.HasData(
                        new
                        {
                            PermisoId = 1,
                            Descripcion = "Administrador",
                            FechaCreacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VecesAsignado = 0
                        },
                        new
                        {
                            PermisoId = 2,
                            Descripcion = "Programador",
                            FechaCreacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VecesAsignado = 0
                        },
                        new
                        {
                            PermisoId = 3,
                            Descripcion = "Diseñador",
                            FechaCreacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VecesAsignado = 0
                        });
                });

            modelBuilder.Entity("RehaciendoElDetalle.Entidades.Roles", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.HasKey("RolId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("RehaciendoElDetalle.Entidades.RolesDetalle", b =>
                {
                    b.Property<int>("RolDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EsAsignado")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PermisoID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PermisoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RolId")
                        .HasColumnType("INTEGER");

                    b.HasKey("RolDetalleId");

                    b.HasIndex("PermisoID");

                    b.HasIndex("RolId");

                    b.ToTable("RolesDetalles");
                });

            modelBuilder.Entity("RehaciendoElDetalle.Entidades.RolesDetalle", b =>
                {
                    b.HasOne("RehaciendoElDetalle.Entidades.Permisos", null)
                        .WithMany("RolesDetalles")
                        .HasForeignKey("PermisoID");

                    b.HasOne("RehaciendoElDetalle.Entidades.Roles", null)
                        .WithMany("RolesDetalle")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RehaciendoElDetalle.Entidades.Permisos", b =>
                {
                    b.Navigation("RolesDetalles");
                });

            modelBuilder.Entity("RehaciendoElDetalle.Entidades.Roles", b =>
                {
                    b.Navigation("RolesDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
