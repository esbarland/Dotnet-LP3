using Model.classes;
using MVC.Converters;
using MVC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class EleveController : Controller
    {
        public ActionResult List()
        {
            List<Eleve> list = BusinessManager.Manager.Instance.GetAllEleve();

            return View(EleveConverter.ConvertListElevesToViewModel(list));
        }
        public ActionResult Info(int id = 0)
        {
            if(id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Eleve selectedEleve = BusinessManager.Manager.Instance.GetOneEleve(id);

            if(selectedEleve == null)
            {
                return HttpNotFound();
            }

            return View(new EleveViewModel(selectedEleve));
        }

        public ActionResult Remove(int id = 0)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            BusinessManager.Manager.Instance.SupprimerEleve(id);

            return RedirectToAction("List", "Eleve");
        }
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(EleveViewModel model)
        {
            if (ModelState.IsValid)
            {
                Eleve e = new Eleve() { Nom = model.Nom, Prenom = model.Prenom, DateDeNaissance = model.DateDeNaissance, ClasseId = 1 };
                BusinessManager.Manager.Instance.AjouterEleve(e);
                return RedirectToAction("List", "Eleve");
            }
            return View(model);
        }

    }
}