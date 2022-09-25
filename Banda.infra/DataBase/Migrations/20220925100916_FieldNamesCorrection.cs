using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Banda.infra.DataBase.Migrations
{
    public partial class FieldNamesCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SOBRENOME",
                table: "GRUPO",
                newName: "SEQUENCIAMUSICA");

            migrationBuilder.RenameColumn(
                name: "NOME",
                table: "GRUPO",
                newName: "NOMEMUSICA");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SEQUENCIAMUSICA",
                table: "GRUPO",
                newName: "SOBRENOME");

            migrationBuilder.RenameColumn(
                name: "NOMEMUSICA",
                table: "GRUPO",
                newName: "NOME");
        }
    }
}
