using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Banda.infra.DataBase.Migrations
{
    public partial class Incial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GRUPO",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DESCRICAO = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    NOME = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    SOBRENOME = table.Column<int>(type: "INT", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoID", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GRUPO");
        }
    }
}
