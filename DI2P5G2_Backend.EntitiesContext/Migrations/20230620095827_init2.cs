﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DI2P5G2_Backend.EntitiesContext.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SensorError",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAbris = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCapteur = table.Column<int>(type: "int", nullable: true),
                    DateTimeRefresh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensorError", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShelterState",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAbris = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTimeRefresh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Available = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShelterState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Favoris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilId = table.Column<int>(type: "int", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    CodePostal = table.Column<int>(type: "int", nullable: true),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pays = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favoris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favoris_Profil_ProfilId",
                        column: x => x.ProfilId,
                        principalTable: "Profil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favoris_ProfilId",
                table: "Favoris",
                column: "ProfilId");

            var sp = @"CREATE PROCEDURE [dbo].[StatUserOnShelter]
                        @IdShelter varchar(50),
                        @StartDatetime datetime2,
                        @EndDatetime datetime2
                    AS 
                    BEGIN 
                        select count(*) as CountUserByShelter from [dbo].[ShelterState]
                        where [ShelterState].[IdAbris] = @IdShelter 
                        and [ShelterState].[DateTimeRefresh] >= @StartDatetime
                        and [ShelterState].[DateTimeRefresh] <= @EndDatetime
                    END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favoris");

            migrationBuilder.DropTable(
                name: "SensorError");

            migrationBuilder.DropTable(
                name: "ShelterState");

            migrationBuilder.DropTable(
                name: "Profil");
        }
    }
}
