using ProjetoLivraria.Banco;
using ProjetoLivraria.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Menu
{
    internal class MenuAdicionar
    {
        public static void AdicionarLivro(DAL<Livros> livroDAL)
        {
            Console.Clear();
            Console.Write("Título do livro: ");
            string nomeLivro = Console.ReadLine();
            Console.Write("Gênero: ");
            string genero = Console.ReadLine();
            Console.Write("Ano de lançamento: ");
            int anoLancamento = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantidade: ");
            int qts = Convert.ToInt32(Console.ReadLine());
            Livros novoLivro = new Livros(nomeLivro, genero, qts, anoLancamento);
            livroDAL.AdicionarLivro(novoLivro);
            Console.WriteLine("Livro adicionado com sucesso!");
            Thread.Sleep(2000);
        }
    }
}
