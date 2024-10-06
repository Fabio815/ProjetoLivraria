// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using ProjetoLivraria.Banco;
using ProjetoLivraria.Menu;
using ProjetoLivraria.Modelos;

var conexao = new LivrariaContext();
var livroDAL = new DAL<Livros>(conexao);

Menu();

void Menu()
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções");
    Console.WriteLine("(1) Adicionar livro\n(2) Atualizar livro\n(3) Deletar livro\n(4) Listar livros");
    Console.Write("Opção: ");
    int opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            MenuAdicionar.AdicionarLivro(livroDAL);
            Menu();
            break;
        case 2:
            MenuAtualizar.AtualizarLivro(livroDAL);
            break;
        case 3:
            MenuDeletarLivro.DeletarLivro(livroDAL);
            Menu();
            break;
        case 4:
            MenuListarLivros.ListarLivros(livroDAL);
            break;
        case 5:
            MenuProcurarLivro.ProcurarLivro(livroDAL);
            Menu();
            break;
    }

}