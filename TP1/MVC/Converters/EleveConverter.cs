using Model.classes;
using MVC.Controllers;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Converters
{
    public class EleveConverter
    {

        public static List<EleveViewModel> ConvertListElevesToViewModel(List<Eleve> list)
        {
            List<EleveViewModel> eleveViewModels = new ArrayList<EleveViewModel>();

            foreach (Eleve e in list)
            {
                eleveViewModels.Add(new EleveViewModel(e));
            }

            return eleveViewModels;
        }



    }
}