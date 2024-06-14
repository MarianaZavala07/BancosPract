﻿// <auto-generated />
using System;
using BancosPract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BancosPract.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240611024005_CrearTablasCompletas")]
    partial class CrearTablasCompletas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BancosPract.Entities.Bancos", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Cash")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoCuenta")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Banco");
                });

            modelBuilder.Entity("BancosPract.Entities.Servicio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BancosId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Costo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("NoCuentaS")
                        .HasColumnType("int");

                    b.Property<string>("NombreS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BancosId");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("BancosPract.Entities.Servicio", b =>
                {
                    b.HasOne("BancosPract.Entities.Bancos", "Bancos")
                        .WithMany("Servicios")
                        .HasForeignKey("BancosId");

                    b.Navigation("Bancos");
                });

            modelBuilder.Entity("BancosPract.Entities.Bancos", b =>
                {
                    b.Navigation("Servicios");
                });
#pragma warning restore 612, 618
        }
    }
}