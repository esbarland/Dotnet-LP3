using Model.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class NoteViewModel
    {

        public int Id { get; set; }
        [DisplayName("Matière")]
        public String Matiere { get; set; }
        [DisplayName("Date de la note")]
        public DateTime DateNote { get; set; }
        [DisplayName("Appréciation")]
        public String Appreciation { get; set; }
        [DisplayName("Valeur")]
        public int Valeur { get; set; }

        public NoteViewModel()
        {

        }
        public NoteViewModel(Note note)
        {
            this.Id = note.Id;
            this.Matiere = note.Matiere;
            this.DateNote = note.DateNote;
            this.Appreciation = note.Appreciation;
            this.Valeur = note.Valeur;
        }


    }
}