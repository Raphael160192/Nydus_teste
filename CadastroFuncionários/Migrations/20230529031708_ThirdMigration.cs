using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroFuncionários.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataDemissao",
                table: "HistoricoCargos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CargoId",
                table: "Colaboradores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_CargoId",
                table: "Colaboradores",
                column: "CargoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradores_Cargos_CargoId",
                table: "Colaboradores",
                column: "CargoId",
                principalTable: "Cargos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradores_Cargos_CargoId",
                table: "Colaboradores");

            migrationBuilder.DropIndex(
                name: "IX_Colaboradores_CargoId",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "DataDemissao",
                table: "HistoricoCargos");

            migrationBuilder.DropColumn(
                name: "CargoId",
                table: "Colaboradores");
        }
    }
}
