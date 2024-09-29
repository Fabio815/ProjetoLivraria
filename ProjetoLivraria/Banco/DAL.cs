using Microsoft.EntityFrameworkCore;
using ProjetoLivraria.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Banco
{
    //O tipo de referência vai ser uma classe.
    internal class DAL<T> where T: class
    {
        //Estou estabelecendo a conexão aqui na classe DAL.
        protected readonly LivrariaContext context;
        
        public DAL(LivrariaContext conexao)
        {
            this.context = conexao;
        }
        
        public IEnumerable<T> Listar()
        {
            //Nesse método de listar estou usando a Set para pegar o tipo de referência.
            return context.Set<T>().ToList();
        }
        public void AdicionarLivro(T objeto)
        {
            //A mesma coisa que acima, só que vou adicionar um objeto.
            context.Set<T>().Add(objeto);
            context.SaveChanges();
        }
        public void Atualizar(T objeto)
        {
            context.Set<T>().Update(objeto);
            context.SaveChanges();
        }
        public void Deletar(T objeto)
        {
            context.Remove(objeto);
            context.SaveChanges();
        }
        public T? EncontrarAlgo(Func<T, bool> condicao)
        {
            var retorno = context.Set<T>().FirstOrDefault(condicao);
            return retorno;
        }
    }
}
