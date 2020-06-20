using Model;
using Model.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Commands
{
    public class NoteCommand
    {
        private readonly ModelContext _context;
        
        public NoteCommand(ModelContext Context)
        {
            _context = Context;
        }

        public int Ajouter(Note n)
        {
            _context.Notes.Add(n);
            return _context.SaveChanges();
        }
        public int Supprimer(int id)
        {
            Note noteToDelete = _context.Notes.Where(n => n.Id == id).FirstOrDefault();
            if(noteToDelete != null)
            {
                _context.Notes.Remove(noteToDelete);
            }
            return _context.SaveChanges();
        }

    }
}