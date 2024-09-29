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
            Console.WriteLine("Listando os livros");
            foreach (var item in livrosDAL.Listar())
            {
                Console.WriteLine($"ID: {item.IdLivro}");
                Console.WriteLine($"Título: {item.Titulo}");
                Console.WriteLine($"Gênero: {item.Genero}");
                Console.WriteLine($"Ano de lançamento: {item.AnoLancamento}");
                Console.WriteLine($"Quantidade: {item.Quantidade}\n");
            }
            Console.ReadKey();
        }
    }
}
