using Model.classes;
using MVC.Converters;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private const int HOME_ELEVES_TO_DISPLAY = 5; 

        public ActionResult Index()
        {
            List<Eleve> allEleves = BusinessManager.Manager.Instance.GetAllEleve();
            List<Eleve> listElevesOff = allEleves.OrderByDescending(e => e.Absences.Count).Take(HOME_ELEVES_TO_DISPLAY).ToList();
            List<EleveBestViewModel> listElevesBest = new List<EleveBestViewModel>();

            foreach(Eleve e in allEleves)
            {
                double moyenneTmp = 0;
                foreach(Note n in e.Notes)
                {
                    moyenneTmp = moyenneTmp + n.Valeur;
                }

                if(moyenneTmp != 0)
                {
                    moyenneTmp = Math.Round(moyenneTmp / e.Notes.Count(), 2);
                }

                listElevesBest.Add(new EleveBestViewModel(e) { MoyenneNotes = moyenneTmp });
            }
            listElevesBest = listElevesBest.OrderByDescending(e => e.MoyenneNotes).Take(HOME_ELEVES_TO_DISPLAY).ToList();

            return View(new HomeViewModel() { ElevesOff = EleveConverter.ConvertListElevesToViewModel(listElevesOff), ElevesBest = listElevesBest });
        }
    }
}