using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroFuncionários.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RazaoSocial",
                table: "Empresas",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeFantasia",
                table: "Empresas",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "Empresas",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    CBO = table.Column<string>(type: "TEXT", nullable: true),
                    DescricaoAtividades = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colaboradores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    CPF = table.Column<string>(type: "TEXT", nullable: true),
                    Matricula = table.Column<string>(type: "TEXT", nullable: true),
                    DataAdmissao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataDemissao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EmpresaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaboradores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colaboradores_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoCargos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CargoId = table.Column<int>(type: "INTEGER", nullable: false),
                    ColaboradorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoCargos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricoCargos_Cargos_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoricoCargos_Colaboradores_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Colaboradores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_EmpresaId",
                table: "Colaboradores",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoCargos_CargoId",
                table: "HistoricoCargos",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoCargos_ColaboradorId",
                table: "HistoricoCargos",
                column: "ColaboradorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricoCargos");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "Colaboradores");

            migrationBuilder.AlterColumn<string>(
                name: "RazaoSocial",
                table: "Empresas",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "NomeFantasia",
                table: "Empresas",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "Empresas",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
