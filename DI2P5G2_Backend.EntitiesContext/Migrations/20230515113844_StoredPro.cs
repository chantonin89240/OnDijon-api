using Microsoft.EntityFrameworkCore.Migrations;
using DI2P5G2_Backend.EntitiesContext;
using System.Diagnostics;

#nullable disable

namespace DI2P5G2_Backend.EntitiesContext.Migrations
{
    public partial class StoredPro : Migration
    {

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CodePostal",
                table: "Favoris",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pays",
                table: "Favoris",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rue",
                table: "Favoris",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ville",
                table: "Favoris",
                type: "nvarchar(max)",
                nullable: true);

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
            migrationBuilder.DropColumn(
                name: "CodePostal",
                table: "Favoris");

            migrationBuilder.DropColumn(
                name: "Pays",
                table: "Favoris");

            migrationBuilder.DropColumn(
                name: "Rue",
                table: "Favoris");

            migrationBuilder.DropColumn(
                name: "Ville",
                table: "Favoris");
        }
    }
}
