using Model.classes;
using MVC.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class EleveViewModel
    {
        public int Id { get; set; }
        [DisplayName("Nom")]
        public String Nom { get; set; }
        [DisplayName("Prénom")]
        public String Prenom { get; set; }
        [DisplayName("Date de naissance")]
        public DateTime DateDeNaissance { get; set; }
        public ICollection<NoteViewModel> Notes { get; set; }
        public ICollection<AbsenceViewModel> Absences { get; set; }
        [DisplayName("Classe")]
        public int ClasseId { get; set; }

        public EleveViewModel()
        {
            this.Notes = new List<NoteViewModel>();
            this.Absences = new List<AbsenceViewModel>();
        }

        public EleveViewModel(Eleve eleve)
        {
            this.Id = eleve.Id;
            this.Nom = eleve.Nom;
            this.Prenom = eleve.Prenom;
            this.DateDeNaissance = eleve.DateDeNaissance;
            this.ClasseId = eleve.ClasseId;
            this.Notes = new List<NoteViewModel>();
            this.Absences = new List<AbsenceViewModel>();

            if (eleve.Notes != null)
            {
                foreach (Note n in eleve.Notes)
                {
                    NoteViewModel noteViewModel = new NoteViewModel(n);
                    this.Notes.Add(noteViewModel);
                }
            }

            if(eleve.Absences != null)
            {
                foreach (Absence a in eleve.Absences)
                {
                    AbsenceViewModel absenceViewModel = new AbsenceViewModel(a);
                    this.Absences.Add(absenceViewModel);
                }
            }
        }
    }
}