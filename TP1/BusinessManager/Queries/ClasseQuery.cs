using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.classes;

namespace BusinessManager.Queries
{
    public class ClasseQuery
    {
        private readonly ModelContext _context;

        public ClasseQuery(ModelContext context)
        {
            _context = context;
        }

        public IQueryable<Classe> GetAll()
        {
            return _context.Classes;
        }
    }
}