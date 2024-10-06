using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoLivraria.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarColunaAnoNascimento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnoNascimento",
                table: "Autores",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnoNascimento",
                table: "Autores");
        }
    }
}
