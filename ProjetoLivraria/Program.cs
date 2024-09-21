// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using ProjetoLivraria.Banco;
using ProjetoLivraria.Modelos;
try
{
    LivrariaContext context = new LivrariaContext();
    LivrosDAL listar = new LivrosDAL(context);
    // listar.AdicionarLivro(new Livros("O Guia do Mochileiro da Galáxia", "Ficção", 200, 2002));
    string livroProcurado = "O senhor dos aneis";
    var  livroAchado = listar.EncontrarLivro(livroProcurado);

    Console.WriteLine(livroAchado.Titulo);
}
catch(Exception ex)
{
   Console.WriteLine($"Erro {ex.Message}");
}
