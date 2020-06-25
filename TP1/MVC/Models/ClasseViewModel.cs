using Model.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class ClasseViewModel
    {
        public int Id { get; set; }
        public String NomEtablissement { get; set; }
        public String Niveau { get; set; }
        public ICollection<Eleve> Eleves { get; set; }

        public ClasseViewModel()
        {
            this.Eleves = new List<Eleve>();
        }

        public ClasseViewModel(Classe classe)
        {
            this.Id = classe.Id;
            this.NomEtablissement = classe.NomEtablissement;
            this.Niveau = classe.Niveau;
        }
    }
}