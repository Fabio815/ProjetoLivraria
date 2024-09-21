// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using ProjetoLivraria.Banco;
using ProjetoLivraria.Modelos;

//try
//{
    LivrosDAL listar = new LivrosDAL();
   // listar.AdicionarLivro(new Livros("O Guia do Mochileiro da Galáxia", "Ficção", 200, 2002));

    var listaDeLivros = listar.Listar();

    foreach(var livros in listaDeLivros)
    {
       Console.WriteLine(livros.Titulo);
    }
//}
//catch(Exception ex)
//{
 //   Console.WriteLine($"Erro {ex.Message}");
//}
