using Model.classes;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class AbsenceController : Controller
    {
        public ActionResult Remove(int id = 0, int EleveId = 0)
        {
            if (id == 0 || EleveId == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            BusinessManager.Manager.Instance.SupprimerAbsence(id);

            return RedirectToAction("Info", "Eleve", new { id = EleveId });
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(AbsenceViewModel model, int EleveId = 0)
        {
            if (EleveId == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (ModelState.IsValid)
            {
                Absence a = new Absence() { Motif = model.Motif, DateAbsence = model.DateAbsence, EleveId = EleveId };
                BusinessManager.Manager.Instance.AjouterAbsence(a);
                return RedirectToAction("Info", "Eleve", new { id = a.EleveId });
            }
            return View(model);
        }
    }
}