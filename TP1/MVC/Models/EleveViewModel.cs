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

        public EleveViewModel(Eleve eleve)
        {
            this.Id = eleve.Id;
            this.Nom = eleve.Nom;
            this.Prenom = eleve.Prenom;
            this.DateDeNaissance = eleve.DateDeNaissance;
        }
    }
}