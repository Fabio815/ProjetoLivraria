using ProjetoLivraria.Banco;
using ProjetoLivraria.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Menu
{
    internal class MenuProcurarLivro
    {
        internal static void ProcurarLivro(DAL<Livros> livroDAL)
        {
            Console.Write("Digite o nome do livro: ");
            string nomeLivro = Console.ReadLine();
            var livroAchado = livroDAL.EncontrarAlgo(livro => livro.Titulo.Equals(nomeLivro));
            if(livroAchado != null)
            {
                Livros livro = new Livros(livroAchado.Titulo, livroAchado.Genero, livroAchado.Quantidade, livroAchado.AnoLancamento);
                Console.WriteLine("Dados do livro");
                livro.ExibirLivro();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Livro não encontrado");
                Thread.Sleep(2000);
            }
        }
    }
}
