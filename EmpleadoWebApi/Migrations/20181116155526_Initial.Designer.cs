﻿// <auto-generated />
using EmpleadoWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EmpleadoWebApi.Migrations
{
    [DbContext(typeof(EmpleadoContext))]
    [Migration("20181116155526_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmpleadoWebApi.Models.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Ciudad");

                    b.Property<string>("Departamento");

                    b.Property<string>("Direccion");

                    b.Property<string>("Email");

                    b.Property<bool>("IsDone");

                    b.Property<string>("Movil");

                    b.Property<string>("Nombre");

                    b.Property<string>("Perfil");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Empleado");
                });
#pragma warning restore 612, 618
        }
    }
}
