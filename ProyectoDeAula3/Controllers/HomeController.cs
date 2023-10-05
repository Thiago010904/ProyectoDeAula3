using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoDeAula3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AgregarNegocio()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult MostrarIdeaNegocio()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}