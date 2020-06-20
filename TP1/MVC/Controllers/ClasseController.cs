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
    public class ClasseController : Controller
    {
        public ActionResult List()
        {
            List<Classe> list = BusinessManager.Manager.Instance.GetAllClasse();

            return View(ClasseConverter.ConvertListClassesToViewModel(list));
        }

    }
}