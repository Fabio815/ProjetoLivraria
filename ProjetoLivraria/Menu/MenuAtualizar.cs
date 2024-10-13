using ProjetoLivraria.Banco;
using ProjetoLivraria.Modelos;

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
                Console.Write("Título do livro: ");
                string tituloLivro = Console.ReadLine();
                Console.Write("Gênero: ");
                string genero = Console.ReadLine();
                Console.Write("Ano de lançamento: ");
                int anoLancamento = Convert.ToInt32(Console.ReadLine());
                Console.Write("Quantidade: ");
                int qts = Convert.ToInt32(Console.ReadLine());
                Livros novoLivro = new(tituloLivro, genero, qts, anoLancamento);
                livrosDAL.Atualizar(novoLivro);
                Console.WriteLine("Livro alterado com sucesso!");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Livro não encontrado!");
                Thread.Sleep(2000);
            }
        }
    }
}