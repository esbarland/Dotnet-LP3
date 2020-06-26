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
                AbsenceQuery aq = new AbsenceQuery(context);
                e.Absences = aq.GetByEleveId(e.Id).ToList();
                eleves.Add(e);
            }
            return eleves;
        }
        public List<Eleve> GetEleveByClasseId(int id)
        {
            EleveQuery eq = new EleveQuery(context);

            return eq.GetAllByClasseId(id) ;
        }
        public Eleve GetOneEleve(int id)
        {
            EleveQuery eq = new EleveQuery(context);
            return eq.GetOne(id);
        }
        public List<Classe> GetAllClasse()
        {
            ClasseQuery cq = new ClasseQuery(context);
            return cq.GetAll().ToList();
        }
        public Classe GetOneClasse(int id)
        {
            ClasseQuery cq = new ClasseQuery(context);
            return cq.GetOne(id);
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
        public int AjouterNote(Note n)
        {
            NoteCommand nc = new NoteCommand(context);
            return nc.Ajouter(n);
        }
        public int AjouterAbsence(Absence a)
        {
            AbsenceCommand ac = new AbsenceCommand(context);
            return ac.Ajouter(a);
        }
        public int SupprimerEleve(int id)
        {
            EleveCommand ec = new EleveCommand(context);
            return ec.Supprimer(id);
        }
        public int SupprimerClasse(int id)
        {
            ClasseCommand cc = new ClasseCommand(context);
            return cc.Supprimer(id);
        }
        public int SupprimerNote(int id)
        {
            NoteCommand nc = new NoteCommand(context);
            return nc.Supprimer(id);
        }
        public int SupprimerAbsence(int id)
        {
            AbsenceCommand ac = new AbsenceCommand(context);
            return ac.Supprimer(id);
        }
        public int ModifierEleve(Eleve e)
        {
            EleveCommand ec = new EleveCommand(context);
            return ec.Modifier(e);
        }
    }
}