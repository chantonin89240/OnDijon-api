﻿// <auto-generated />
using System;
using DI2P5G2_Backend.EntitiesContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DI2P5G2_Backend.EntitiesContext.Migrations
{
    [DbContext(typeof(DI2P5G2_BackendDbContext))]
    [Migration("20230628084003_initIA")]
    partial class initIA
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DI2P5G2_Backend.Entity.Favoris", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int?>("CodePostal")
                        .HasColumnType("int");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Pays")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfilId")
                        .HasColumnType("int");

                    b.Property<string>("Rue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProfilId");

                    b.ToTable("Favoris");
                });

            modelBuilder.Entity("DI2P5G2_Backend.Entity.Profil", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<Guid?>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profil");
                });

            modelBuilder.Entity("DI2P5G2_Backend.Entity.SensorError", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateTimeRefresh")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdAbris")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdCapteur")
                        .HasColumnType("int");

                    b.Property<string>("Libelle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SensorError");
                });

            modelBuilder.Entity("DI2P5G2_Backend.Entity.ShelterState", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int?>("Available")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateTimeRefresh")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdAbris")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ShelterState");
                });

            modelBuilder.Entity("DI2P5G2_Backend.Entity.ShelterStateIA", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateTimeRefresh")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdAbris")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TotalVelo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ShelterStateIA");
                });

            modelBuilder.Entity("DI2P5G2_Backend.Entity.Favoris", b =>
                {
                    b.HasOne("DI2P5G2_Backend.Entity.Profil", null)
                        .WithMany()
                        .HasForeignKey("ProfilId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
