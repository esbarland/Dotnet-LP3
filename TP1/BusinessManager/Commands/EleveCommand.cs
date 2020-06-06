using Model;
using Model.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Commands
{
    public class EleveCommand
    {
        private readonly ModelContext _context;
        
        public EleveCommand(ModelContext Context)
        {
            _context = Context;
        }

        public int Ajouter(Eleve e)
        {
            _context.Eleves.Add(e);
            return _context.SaveChanges();
        }

    }
}