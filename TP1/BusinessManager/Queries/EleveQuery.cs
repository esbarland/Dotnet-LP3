using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.classes;

namespace BusinessManager.Queries
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
        public Eleve GetOne(int id)
        {
            return _context.Eleves.Where(e => e.Id == id).FirstOrDefault();
        }
        public List<Eleve> GetAllByClasseId(int id)
        {
            List<Eleve> list = new List<Eleve>();

            foreach(Eleve e in _context.Eleves)
            {
                if(e.ClasseId == id)
                {
                    list.Add(e);
                }
            }

            return list;
        }


    }
}