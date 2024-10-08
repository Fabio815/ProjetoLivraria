﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjetoLivraria.Modelos;

namespace ProjetoLivraria.Banco;

internal class LivrariaContext : DbContext
{
    private string conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Livraria01;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(conexao);
    }

    public SqlConnection ObterConexao()
    {
        return new SqlConnection(conexao);
    }

    public DbSet<Livros> Livros { get; set; }
    public DbSet<Autor> Autores { get; set; }
}
