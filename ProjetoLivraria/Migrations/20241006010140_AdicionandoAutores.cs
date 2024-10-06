using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoLivraria.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoAutores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Autores", new string[] { "Nome", "Nacionalidade", "AnoNascimento" },
                new object[] { "George Orwell", "Índia", 1903 });
            migrationBuilder.InsertData("Autores", new string[] { "Nome", "Nacionalidade", "AnoNascimento" },
                new object[] { "Tolkin", "EUA", 1905 });
            migrationBuilder.InsertData("Autores", new string[] { "Nome", "Nacionalidade", "AnoNascimento" },
                new object[] { "Douglas Addams", "Britania", 1977 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Autores");
        }
    }
}
