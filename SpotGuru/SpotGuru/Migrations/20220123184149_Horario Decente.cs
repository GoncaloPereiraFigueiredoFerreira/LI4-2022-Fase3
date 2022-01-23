using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpotGuru.Migrations
{
    public partial class HorarioDecente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoraFinal",
                table: "Slots");

            migrationBuilder.RenameColumn(
                name: "HoraEncerrament",
                table: "Horario",
                newName: "HoraEncerramento");

            migrationBuilder.AddColumn<int>(
                name: "DuracaoSlot",
                table: "Horario",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DuracaoSlot",
                table: "Horario");

            migrationBuilder.RenameColumn(
                name: "HoraEncerramento",
                table: "Horario",
                newName: "HoraEncerrament");

            migrationBuilder.AddColumn<DateTime>(
                name: "HoraFinal",
                table: "Slots",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
