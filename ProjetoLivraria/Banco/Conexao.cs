using Microsoft.Data.SqlClient;

namespace ProjetoLivraria.Banco;

internal class Conexao
{
    private string conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Livraria;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    public SqlConnection AbrirConexao()
    {
        return new SqlConnection(conexao);
    }
}
