using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teste1.Migrations
{
    public partial class CriacaoBd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curriculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Funcao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<int>(type: "int", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dta_Nasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salario = table.Column<float>(type: "real", nullable: false),
                    Obs = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curriculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vagas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Funcao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nme_Empresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescVaga = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salario = table.Column<float>(type: "real", nullable: false),
                    Dta_Cadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vagas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Curriculos");

            migrationBuilder.DropTable(
                name: "Vagas");
        }
    }
}
