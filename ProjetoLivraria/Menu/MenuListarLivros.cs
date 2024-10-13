using ProjetoLivraria.Banco;
using ProjetoLivraria.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Menu
{
    internal class MenuListarLivros
    {
        public static void ListarLivros(DAL<Livros> livrosDAL)
        {
            Console.Clear();
            if (livrosDAL != null)
            {
                Console.WriteLine("Listando os livros");
                foreach (var item in livrosDAL.Listar())
                {
                    item.ExibirLivro();
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nenhum livro cadastrado!");
                Thread.Sleep(2000);
            }
        }
    }
}
