using Model.classes;
using MVC.Controllers;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Converters
{
    public class AbsenceConverter
    {

        public static List<AbsenceViewModel> ConvertListAbsencesToViewModel(List<Absence> list)
        {
            List<AbsenceViewModel> absenceViewModels = new List<AbsenceViewModel>();

            foreach (Absence a in list)
            {
                absenceViewModels.Add(new AbsenceViewModel(a));
            }

            return absenceViewModels;
        }



    }
}