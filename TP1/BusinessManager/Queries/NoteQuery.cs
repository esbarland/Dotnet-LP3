using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.classes;

namespace BusinessManager.Queries
{
    public class NoteQuery
    {
        private readonly ModelContext _context;

        public NoteQuery(ModelContext context)
        {
            _context = context;
        }

        public IQueryable<Note> GetAll()
        {
            return _context.Notes;
        }

        public IQueryable<Note> GetByEleveId(int EleveId)
        {
            return _context.Notes.Where(n => n.EleveId == EleveId);
        }
    }
}