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

        public static Livros AdicionarLivroMenu()
        {
            Livros novoLivro = new ("Pão", "Ação", 2012, 2019);
            LivrosDAL livrosDAL = new();
            return AdicionarLivro();
        }
    }
}
