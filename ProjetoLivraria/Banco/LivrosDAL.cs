using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProjetoLivraria.Modelos;

namespace ProjetoLivraria.Banco;

internal class LivrosDAL : DAL<Livros>
{
    //Estou fazendo com que seja aberto a conexão atráves desse construtor.
    public LivrosDAL(LivrariaContext conexao) : base(conexao) { }

    public Livros? EncontrarLivro(string livroProcurado)
    {
        var livroEncontrado = context.Livros.FirstOrDefault(livro => livro.Titulo.Equals(livroProcurado));
        return livroEncontrado;
    }
}
