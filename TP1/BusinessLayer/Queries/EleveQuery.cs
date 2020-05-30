using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.classes;

namespace BusinessLayer.Queries
{
    public class EleveQuery
    {
        private readonly ModelContext _context;

        public EleveQuery(ModelContext context)
        {
            _context = context;
        }

        public IQueryable<Eleve> GetAll()
        {
            return _context.Eleves;
        }
    }
}