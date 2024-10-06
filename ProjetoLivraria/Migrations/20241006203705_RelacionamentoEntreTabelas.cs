using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoLivraria.Migrations
{
    /// <inheritdoc />
    public partial class RelacionamentoEntreTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AutorIdAutor",
                table: "Livros",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Livros_AutorIdAutor",
                table: "Livros",
                column: "AutorIdAutor");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Autores_AutorIdAutor",
                table: "Livros",
                column: "AutorIdAutor",
                principalTable: "Autores",
                principalColumn: "IdAutor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Autores_AutorIdAutor",
                table: "Livros");

            migrationBuilder.DropIndex(
                name: "IX_Livros_AutorIdAutor",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "AutorIdAutor",
                table: "Livros");
        }
    }
}
