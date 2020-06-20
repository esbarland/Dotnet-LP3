using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.classes;

namespace BusinessManager.Queries
{
    public class AbsenceQuery
    {
        private readonly ModelContext _context;

        public AbsenceQuery(ModelContext context)
        {
            _context = context;
        }

        public IQueryable<Absence> GetAll()
        {
            return _context.Absences;
        }

        public IQueryable<Absence> GetByEleveId(int EleveId)
        {
            return _context.Absences.Where(n => n.EleveId == EleveId);
        }
    }
}