using CrystalSorter.Generator;
using CrystalSorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrystalSorter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var crystals = new List<Crystal>();

            var crystal = new CrystalGen();
            crystals = crystal.Generate();

            return View(crystals);
        }

        public JsonResult Crystals()
        {
            var crystals = new List<Crystal>();

            var crystal = new CrystalGen();
            crystals = crystal.Generate();
            
            return Json(crystals, JsonRequestBehavior.AllowGet);
        }
    }
}