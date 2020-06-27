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
        public ICollection<AbsenceViewModel> AbsencesLast { get; set; }

        public HomeViewModel()
        {
            this.ElevesBest = new List<EleveBestViewModel>();
            this.AbsencesLast = new List<AbsenceViewModel>();
        }

    }
}