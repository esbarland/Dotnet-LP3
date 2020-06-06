using Model;
using Model.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Commands
{
    public class ClasseCommand
    {
        private readonly ModelContext _context;

        public ClasseCommand(ModelContext Context)
        {
            _context = Context;
        }

        public int Ajouter(Classe c)
        {
            _context.Classes.Add(c);
            return _context.SaveChanges();
        }

    }
}