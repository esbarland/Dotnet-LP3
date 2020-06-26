using Model.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class AbsenceViewModel
    {
        public int Id { get; set; }

        public DateTime DateAbsence { get; set; }
        public String Motif { get; set; }

        public AbsenceViewModel()
        {

        }
        public AbsenceViewModel(Absence absence)
        {
            this.Id = absence.Id;
            this.DateAbsence = absence.DateAbsence;
            this.Motif = absence.Motif;
        }

    }
}