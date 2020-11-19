using Microsoft.EntityFrameworkCore.Migrations;

namespace AEROAPI.Migrations
{
    public partial class AdicionaColunaCidadeTabelaLocal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Locais",
                newName: "Nome");

            migrationBuilder.AddColumn<string>(
                name: "cidade",
                table: "Locais",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cidade",
                table: "Locais");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Locais",
                newName: "nome");
        }
    }
}
