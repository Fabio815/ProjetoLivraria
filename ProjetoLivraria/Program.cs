// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using ProjetoLivraria.Banco;

try
{
    ListarDAL listar = new ListarDAL();
    var listaDeLivros = listar.Listar();

    foreach(var livros in listaDeLivros)
    {
        Console.WriteLine(livros.Titulo);
    }
}
catch(Exception ex)
{
    Console.WriteLine($"Erro {ex.Message}");
}
