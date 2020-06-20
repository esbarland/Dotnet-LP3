using Model.classes;
using MVC.Controllers;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Converters
{
    public class ClasseConverter
    {

        public static List<ClasseViewModel> ConvertListClassesToViewModel(List<Classe> list)
        {
            List<ClasseViewModel> classeViewModels = new List<ClasseViewModel>();

            foreach (Classe c in list)
            {
                classeViewModels.Add(new ClasseViewModel(c));
            }

            return classeViewModels;
        }



    }
}