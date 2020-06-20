using Model.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class EleveViewModel
    {
        public int Id { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public ICollection<Note> Notes { get; set; }
        public ICollection<Absence> Absences { get; set; }

        public EleveViewModel()
        {
            this.Notes = new List<Note>();
            this.Absences = new List<Absence>();
        }

        public EleveViewModel(Eleve eleve)
        {
            this.Id = eleve.Id;
            this.Nom = eleve.Nom;
            this.Prenom = eleve.Prenom;
            this.DateDeNaissance = eleve.DateDeNaissance;
            if(eleve.Notes.Count() == 0)
            {
                this.Notes = new List<Note>();
            }
            else
            {
                this.Notes = eleve.Notes;
            }
            if (eleve.Absences.Count() == 0)
            {
                this.Absences = new List<Absence>();
            }
            else
            {
                this.Absences= eleve.Absences;
            }
        }
    }
}