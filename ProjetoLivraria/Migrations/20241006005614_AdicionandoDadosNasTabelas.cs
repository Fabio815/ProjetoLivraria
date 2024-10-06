using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoLivraria.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoDadosNasTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Livros", new string[] { "Titulo", "Genero", "Quantidade", "AnoLancamento" },
    new object[] { "O Senhor dos Aneis", "Ficção", 291, 1967 });
            migrationBuilder.InsertData("Livros", new string[] { "Titulo", "Genero", "Quantidade", "AnoLancamento" },
                new object[] { "O Guia do Mochileiro da Galáxia", "Ficção", 440, 2002 });


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Autores");
            migrationBuilder.Sql("DELETE FROM Livros");
        }
    }
}
