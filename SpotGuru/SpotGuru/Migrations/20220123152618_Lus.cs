using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpotGuru.Migrations
{
    public partial class Lus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dia",
                table: "Slots");

            migrationBuilder.DropColumn(
                name: "Hora",
                table: "Slots");

            migrationBuilder.AddColumn<DateTime>(
                name: "HoraFinal",
                table: "Slots",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "HoraInicial",
                table: "Slots",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoraFinal",
                table: "Slots");

            migrationBuilder.DropColumn(
                name: "HoraInicial",
                table: "Slots");

            migrationBuilder.AddColumn<int>(
                name: "Dia",
                table: "Slots",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Hora",
                table: "Slots",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
