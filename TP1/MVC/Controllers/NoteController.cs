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
    public class NoteController : Controller
    {
        public ActionResult Remove(int id = 0, int EleveId = 0)
        {
            if (id == 0 || EleveId == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            BusinessManager.Manager.Instance.SupprimerNote(id);

            return RedirectToAction("Info", "Eleve", new { id = EleveId });
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(NoteViewModel model, int EleveId = 0)
        {
            if (EleveId == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (ModelState.IsValid)
            {
                Note n = new Note() { Matiere = model.Matiere, Appreciation = model.Appreciation, DateNote = model.DateNote, Valeur = model.Valeur, EleveId = EleveId };
                BusinessManager.Manager.Instance.AjouterNote(n);
                return RedirectToAction("Info", "Eleve", new { id = n.EleveId });
            }
            return View(model);
        }

    }
}