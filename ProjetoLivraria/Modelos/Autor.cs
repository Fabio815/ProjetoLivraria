namespace ProjetoLivraria.Modelos;

internal class Autor
{
    List<Livros> listaLivro = new List<Livros>();
    public int IdAutor { get; set; }
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }

    public void AdicionarLivrosAoAutor(Livros livros)
    {
        listaLivro.Add(livros);
    }
}
