using ProjetoLivraria.Banco;
using ProjetoLivraria.Modelos;

namespace ProjetoLivraria.Menu
{
    internal class MenuDeletarLivro
    {
        internal static void DeletarLivro(DAL<Livros> livroDAL)
        {
            Console.WriteLine("Deletar por (1) Título ou (2) ID");
            int opcao = Convert.ToInt32(Console.ReadLine());
            if(opcao == 1)
            {
                string procurarPorTitulo;
                Console.WriteLine("Digite o título da obra: ");
                procurarPorTitulo = Console.ReadLine();
                var livroApagado = livroDAL.EncontrarAlgo(livro => livro.Titulo.Equals(procurarPorTitulo));
                Livros mostrarLivro = new(livroApagado.Titulo, livroApagado.Genero, livroApagado.Quantidade, livroApagado.AnoLancamento);
                if (livroApagado != null)
                {
                    Console.Write("Confirmar operação [1] SIM / [2] NÃO: ");
                    int confirmacao = int.Parse(Console.ReadLine());
                    if (confirmacao == 1)
                    {
                        livroDAL.Deletar(livroApagado);
                        Console.WriteLine("Livro deletado com sucesso!");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("Operação cancelada");
                    }
                }
                else
                {
                    Console.WriteLine("Livro não encontrado");
                }
            }
            else
            {
                int procuradoPorId;
                Console.WriteLine("Digite o ID da obra: ");
                procuradoPorId = Convert.ToInt32(Console.ReadLine());
                var livroApagado = livroDAL.EncontrarAlgo(livro => livro.IdLivro == procuradoPorId);
                Livros mostrarLivro = new(livroApagado.Titulo, livroApagado.Genero, livroApagado.Quantidade, livroApagado.AnoLancamento);
                mostrarLivro.ExibirLivro();
                if (livroApagado != null)
                {
                    Console.Write("Confirmar operação [1] SIM / [2] NÃO: ");
                    int confirmacao = int.Parse(Console.ReadLine());
                    if(confirmacao == 1)
                    {
                        livroDAL.Deletar(livroApagado);
                        Console.WriteLine("Livro deletado com sucesso!");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("Operação cancelada");
                    }
                }
                else
                {
                    Console.WriteLine("Livro não encontrado!");
                }
            }
        }
    }
}
