using Model.classes;
using MVC.Converters;
using MVC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ClasseController : Controller
    {
        public ActionResult Index(string search)
        {
            List<Classe> list = BusinessManager.Manager.Instance.GetAllClasse();

            if (!String.IsNullOrEmpty(search))
            {
                list = list.Where(e => e.NomEtablissement.ToLower().Contains(search.ToLower()) || e.Niveau.ToLower().Contains(search.ToLower())).ToList();
            }

            return View(ClasseConverter.ConvertListClassesToViewModel(list));
        }
        public ActionResult Info(int id = 0)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Classe selectedClasse = BusinessManager.Manager.Instance.GetOneClasse(id);

            if (selectedClasse == null)
            {
                return HttpNotFound();
            }

            List<Eleve> listEleves = BusinessManager.Manager.Instance.GetEleveByClasseId(selectedClasse.Id);

            return View(new ClasseViewModel(selectedClasse) { Eleves = listEleves });
        }

        public ActionResult Remove(int id = 0)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            BusinessManager.Manager.Instance.SupprimerClasse(id);

            return RedirectToAction("Index", "Classe");
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(ClasseViewModel model)
        {
            if (ModelState.IsValid)
            {
                Classe c = new Classe() { Niveau = model.Niveau, NomEtablissement = model.NomEtablissement };
                BusinessManager.Manager.Instance.AjouterClasse(c);
                return RedirectToAction("Index", "Classe");
            }
            return View(model);
        }

    }
}