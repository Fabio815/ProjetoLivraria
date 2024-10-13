using ProjetoLivraria.Banco;
using ProjetoLivraria.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Menu
{
    internal class MenuListarPorAno
    {
        public static void OrdenarPorAno(DAL<Livros> livros)
        {
            Console.Clear();
            Console.WriteLine("Digite o ano de lançamento da música: ");
            int anoRequerido = Convert.ToInt32(Console.ReadLine());
            var lista = livros.ListarPorAlgo(livro => livro.AnoLancamento == anoRequerido);
            foreach(var item in lista)
            {
                item.ExibirLivro();
            }
            Console.ReadKey();
        }
    }
}
