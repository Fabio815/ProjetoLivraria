// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using ProjetoLivraria.Banco;
using ProjetoLivraria.Modelos;
//try

    LivrariaContext context = new LivrariaContext();
    LivrosDAL listar = new LivrosDAL(context);
    
    listar.Deletar(novoLivro);


//catch(Exception ex)

 //  Console.WriteLine($"Erro {ex.Message}");

