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
        public ICollection<EleveViewModel> Eleves { get; set; }

        public ClasseViewModel()
        {
            this.Eleves = new List<EleveViewModel>();
        }

        public ClasseViewModel(Classe classe)
        {
            this.Id = classe.Id;
            this.NomEtablissement = classe.NomEtablissement;
            this.Niveau = classe.Niveau;
            this.Eleves = new List<EleveViewModel>();

            if(classe.Eleves != null)
            {
                foreach (Eleve e in classe.Eleves)
                {
                    EleveViewModel eleveViewModel = new EleveViewModel(e);
                    this.Eleves.Add(eleveViewModel);
                }
            }
        }
    }
}