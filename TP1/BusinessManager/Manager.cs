using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessManager.Commands;
using BusinessManager.Queries;
using Model;
using Model.classes;

namespace BusinessManager
{
    public class Manager
    {
        private readonly ModelContext context;
        private static Manager _businessManager = null;

        private Manager()
        {
            context = new ModelContext();
        }

        public static Manager Instance
        {
            get
            {
                if (_businessManager == null)
                    _businessManager = new Manager();
                return _businessManager;
            }
        }

        public List<Eleve> GetAllEleve()
        {
            EleveQuery eq = new EleveQuery(context);

            List<Eleve> eleves = new List<Eleve>();
                        
            foreach(Eleve e in eq.GetAll().ToList())
            {
                NoteQuery nq = new NoteQuery(context);
                e.Notes = nq.GetByEleveId(e.Id).ToList();
                eleves.Add(e);
            }
            return eleves;
        }
        public List<Note> GetAllNote()
        {
            NoteQuery nq = new NoteQuery(context);
            return nq.GetAll().ToList();
        }
        public int AjouterEleve(Eleve e)
        {
            EleveCommand ec = new EleveCommand(context);
            return ec.Ajouter(e);
        }
        public int AjouterClasse(Classe c)
        {
            ClasseCommand cc = new ClasseCommand(context);
            return cc.Ajouter(c);
        }
    }
}