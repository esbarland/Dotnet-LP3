using Model;
using Model.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Commands
{
    public class AbsenceCommand
    {
        private readonly ModelContext _context;
        
        public AbsenceCommand(ModelContext Context)
        {
            _context = Context;
        }

        public int Ajouter(Absence a)
        {
            _context.Absences.Add(a);
            return _context.SaveChanges();
        }
        public int Supprimer(int id)
        {
            Absence absenceToDelete = _context.Absences.Where(n => n.Id == id).FirstOrDefault();
            if(absenceToDelete != null)
            {
                _context.Absences.Remove(absenceToDelete);
            }
            return _context.SaveChanges();
        }

    }
}