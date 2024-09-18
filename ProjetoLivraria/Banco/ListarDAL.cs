using Microsoft.Data.SqlClient;
using ProjetoLivraria.Modelos;

namespace ProjetoLivraria.Banco;

internal class ListarDAL
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

        while(leitura.Read())
        {
            string titulo = Convert.ToString(leitura["Titulo"]);
            string genero = Convert.ToString(leitura["Genero"]);
            int quantidade = Convert.ToInt32(leitura["Quantidade"]);
            int anoLancamento = Convert.ToInt32(leitura["AnoLancamento"]);
            int idLivros = Convert.ToInt32(leitura["IdLivro"]);
            Livros livros = new(titulo, genero, quantidade, anoLancamento) { IdLivro = idLivros};

            listaLivros.Add(livros);
        }

        return listaLivros;
    }
}
