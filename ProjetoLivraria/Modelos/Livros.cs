using System.ComponentModel.DataAnnotations;

namespace ProjetoLivraria.Modelos;

internal class Livros
{
    private string anoLancamento;

    public Livros(string titulo, string genero, int quantidade, int anoLancamento)
    {
        Titulo = titulo;
        Genero = genero;
        Quantidade = quantidade;
        AnoLancamento = anoLancamento;
    }

    [Key]
    public int IdLivro { get; set; }
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int Quantidade { get; set; }
    public int AnoLancamento { get; set; }
}
