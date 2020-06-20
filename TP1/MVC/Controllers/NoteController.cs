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
        /*public ActionResult Remove(int id = 0)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            BusinessManager.Manager.Instance.SupprimerEleve(id);

            return RedirectToAction("List", "Eleve");
        }*/

        public ActionResult Add(int EleveId = 0)
        {
            if(EleveId == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Note note = new Note() { DateNote = DateTime.Now, Matiere = "Maths", Valeur = 14, Appreciation = "Bon travail", EleveId = EleveId };
            BusinessManager.Manager.Instance.AjouterNote(note);

            return RedirectToAction("Info", "Eleve", new { id = EleveId });
        }

    }
}