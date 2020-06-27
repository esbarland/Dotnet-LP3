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
            List<EleveBestViewModel> listElevesBest = new List<EleveBestViewModel>();

            // Récupérer une liste des meilleurs élèves en fonction de leur moyenne
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

            // Récupérer une liste des 5 derniers absents
            List<Absence> listAbsencesLast = BusinessManager.Manager.Instance.GetAllAbsences().OrderByDescending(a => a.DateAbsence).Take(HOME_ELEVES_TO_DISPLAY).ToList();

            return View(new HomeViewModel() { AbsencesLast = AbsenceConverter.ConvertListAbsencesToViewModel(listAbsencesLast), ElevesBest = listElevesBest });
        }
    }
}