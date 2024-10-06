using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoLivraria.Migrations
{
    /// <inheritdoc />
    public partial class PreenchendoAutorIf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Livros SET AutorIdAutor = 1 WHERE IdLivro = 1");
            migrationBuilder.Sql("UPDATE Livros SET AutorIdAutor = 2 WHERE IdLivro = 2");
            migrationBuilder.Sql("UPDATE Livros SET AutorIdAutor = 3 WHERE IdLivro = 3");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
