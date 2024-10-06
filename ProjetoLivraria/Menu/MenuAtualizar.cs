using ProjetoLivraria.Banco;
using ProjetoLivraria.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Menu
{
    internal class MenuAtualizar
    {

        internal static void AtualizarLivro(DAL<Livros> livrosDAL)
        {
            Console.WriteLine("Digite o livro que deseja atualizar");
            string nomeLivro = Console.ReadLine();
            var livroAchado = livrosDAL.EncontrarAlgo(livro => livro.Titulo.Equals(nomeLivro));
            if (livroAchado != null)
            {
                Console.WriteLine("Digite os dados do livro novamente");
                Console.WriteLine("Título: ");
                string tituloLivro = Console.ReadLine();
            }
        }
    }
}