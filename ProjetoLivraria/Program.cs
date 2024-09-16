// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using ProjetoLivraria.Banco;

try
{
    SqlConnection conexao = new Conexao().AbrirConexao();
    conexao.Open();
    Console.WriteLine(conexao.State);
}
catch(Exception ex)
{
    Console.WriteLine($"Erro {ex.Message}");
}
