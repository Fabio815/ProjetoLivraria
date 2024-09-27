using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Menu
{
    internal class Menu
    {
        public virtual void MenuPrincipal()
        {
            Console.WriteLine("Escolha uma das opções");
            Console.WriteLine("(1) Adicionar livro\n (2) Listar livros\n (3) Buscar livro\n (4) Deletar livro");
            int opcao = Convert.ToInt32(Console.ReadLine());
            switch(opcao)
            {
                case 1:
                    MenuAdicionar.AdicionarLivro();
                    break;
            }
        }
    }
}
