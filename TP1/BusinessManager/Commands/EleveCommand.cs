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
        public int Supprimer(int id)
        {
            Eleve eleveToDelete = _context.Eleves.Where(e => e.Id == id).FirstOrDefault();
            if(eleveToDelete != null)
            {
                _context.Eleves.Remove(eleveToDelete);
            }
            return _context.SaveChanges();
        }
        public int Modifier(Eleve eleve)
        {
            Eleve eleveToUpdate = _context.Eleves.Where(e => e.Id == eleve.Id).FirstOrDefault();
            if (eleveToUpdate != null)
            {
                eleveToUpdate.Nom = eleve.Nom;
                eleveToUpdate.Prenom = eleve.Prenom;
                eleveToUpdate.DateDeNaissance = eleve.DateDeNaissance;
            }
            return _context.SaveChanges();
        }

    }
}