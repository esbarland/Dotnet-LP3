using Model.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class NoteViewModel
    {

        public int Id { get; set; }
        public String Matiere { get; set; }
        public DateTime DateNote { get; set; }
        public String Appreciation { get; set; }
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