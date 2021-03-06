﻿using Model.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class AbsenceViewModel
    {
        public int Id { get; set; }
        [DisplayName("Date d'absence")]
        public DateTime DateAbsence { get; set; }
        [DisplayName("Motif")]
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