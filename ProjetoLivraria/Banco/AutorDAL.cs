using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Banco
{
    internal class AutorDAL
    {
        private readonly LivrariaContext context;
        public AutorDAL(LivrariaContext _context)
        {
            this.context = _context;
        }

    }
}
