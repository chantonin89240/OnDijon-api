using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DI2P5G2_Backend.EntitiesContext.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeRefresh",
                table: "SensorError",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTimeRefresh",
                table: "SensorError");
        }
    }
}
