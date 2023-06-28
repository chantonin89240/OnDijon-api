using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DI2P5G2_Backend.EntitiesContext.Migrations
{
    public partial class initIA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShelterStateIA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAbris = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTimeRefresh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalVelo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShelterStateIA", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShelterStateIA");
        }
    }
}
