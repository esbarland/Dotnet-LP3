using Model.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class HomeViewModel
    {
        public ICollection<EleveBestViewModel> ElevesBest { get; set; }
        public ICollection<Eleve> ElevesOff { get; set; }

        public HomeViewModel()
        {
            this.ElevesBest = new List<EleveBestViewModel>();
            this.ElevesOff = new List<Eleve>();
        }

    }
}