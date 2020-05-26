﻿// <auto-generated />
using MASCOTAAPP.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MASCOTAAPP.Migrations
{
    [DbContext(typeof(MascotaContext))]
    [Migration("20190522203911_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MASCOTAAPP.Models.Mascota", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EdadAproximada");

                    b.Property<string>("NombreTemporal");

                    b.Property<int>("TipoID");

                    b.HasKey("ID");

                    b.HasIndex("TipoID");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("MASCOTAAPP.Models.TipoMascota", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("ID");

                    b.ToTable("Tipos");
                });

            modelBuilder.Entity("MASCOTAAPP.Models.Mascota", b =>
                {
                    b.HasOne("MASCOTAAPP.Models.TipoMascota", "Tipo")
                        .WithMany("Mascotas")
                        .HasForeignKey("TipoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
