using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProjetoLivraria.Modelos;

namespace ProjetoLivraria.Banco;

internal class LivrosDAL
{
    //Estou fazendo com que seja aberto a conexão atráves desse construtor.
    private readonly LivrariaContext context;
    public LivrosDAL(LivrariaContext conexao)
    {
        this.context = conexao;
    }

    public IEnumerable<Livros> Listar()
    {     
        return context.Livros.ToList();

        /*string sql = "SELECT * FROM Livros";
        SqlCommand comando = new SqlCommand(sql, abrirConexao);
        using SqlDataReader leitura = comando.ExecuteReader();
        //Nessa parte estou colocando os dados em variáveis.
        while(leitura.Read())
        {
            string titulo = Convert.ToString(leitura["Titulo"]);
            string genero = Convert.ToString(leitura["Genero"]);
            int quantidade = Convert.ToInt32(leitura["Quantidade"]);
            int anoLancamento = Convert.ToInt32(leitura["AnoLancamento"]);
            int idLivros = Convert.ToInt32(leitura["IdLivro"]);
            //Agora estou colocando elas em uma variáveis, para adicionar na lista de livros que declarei no começo.
            Livros livros = new(titulo, genero, quantidade, anoLancamento) { IdLivro = idLivros};

            listaLivros.Add(livros);
        }

        return listaLivros;*/
    }

    public void AdicionarLivro(Livros livro)
    {
        context.Livros.Add(livro);
        context.SaveChanges();

        /*string sql = "INSERT INTO Livros(Titulo, Genero, Quantidade, AnoLancamento) VALUES (@titulo, @genero, @quantidade, @lancamento)";
        SqlCommand comando = new SqlCommand(sql, abrirConexao);

        comando.Parameters.AddWithValue("@titulo", livro.Titulo);
        comando.Parameters.AddWithValue("@genero", livro.Genero);
        comando.Parameters.AddWithValue("@quantidade", livro.Quantidade);
        comando.Parameters.AddWithValue("@lancamento", livro.AnoLancamento);

        int retorno = comando.ExecuteNonQuery();
        Console.WriteLine(retorno);*/
    }

    public void Atualizar(Livros livros)
    {
        context.Update(livros);
        context.SaveChanges();


    }

    public void Deletar(Livros livro)
    {
        LivrariaContext connection = new LivrariaContext();
        var abrirConexao = connection.ObterConexao();
        abrirConexao.Open();
        //context.Remove(livros);
        //context.SaveChanges();
        string sqlQuery = $"DELETE FROM Livros WHERE IdLivro = @idLivro";
        SqlCommand comando = new SqlCommand(sqlQuery, abrirConexao);

        comando.Parameters.AddWithValue("@idLivro", livro.IdLivro);
        int retorno = comando.ExecuteNonQuery();
        Console.WriteLine("Deletado.");
    }

    public Livros? EncontrarLivro(string livroProcurado)
    {
        var livroEncontrado = context.Livros.FirstOrDefault(livro => livro.Titulo.Equals(livroProcurado));
        return livroEncontrado;
    }
}
