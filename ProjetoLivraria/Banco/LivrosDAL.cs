using Microsoft.Data.SqlClient;
using ProjetoLivraria.Modelos;

namespace ProjetoLivraria.Banco;

internal class LivrosDAL
{
    public IEnumerable<Livros> Listar()
    {
        var listaLivros = new List<Livros>();
        //Abrindo conexão com o banco de dados.
        using var abrirConexao = new Conexao().AbrirConexao();
        abrirConexao.Open();

        string sql = "SELECT * FROM Livros";
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

        return listaLivros;
    }

    public void AdicionarLivro(Livros livro)
    {
        using var abrirConexao = new Conexao().AbrirConexao();
        abrirConexao.Open();

        string sql = "INSERT INTO Livros(Titulo, Genero, Quantidade, AnoLancamento) VALUES (@titulo, @genero, @quantidade, @lancamento)";
        SqlCommand comando = new SqlCommand(sql, abrirConexao);

        comando.Parameters.AddWithValue("@titulo", livro.Titulo);
        comando.Parameters.AddWithValue("@genero", livro.Genero);
        comando.Parameters.AddWithValue("@quantidade", livro.Quantidade);
        comando.Parameters.AddWithValue("@lancamento", livro.AnoLancamento);

        int retorno = comando.ExecuteNonQuery();
        Console.WriteLine(retorno);
    }
}
