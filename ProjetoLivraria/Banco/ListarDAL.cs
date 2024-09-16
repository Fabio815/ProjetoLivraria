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
    }
}
