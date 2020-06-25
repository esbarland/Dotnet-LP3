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
        public int Supprimer(int id)
        {
            Classe classeToDelete = _context.Classes.Where(n => n.Id == id).FirstOrDefault();
            if (classeToDelete != null)
            {
                _context.Classes.Remove(classeToDelete);
            }
            return _context.SaveChanges();
        }

    }
}