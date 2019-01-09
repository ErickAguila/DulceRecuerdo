using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DulceRecuerdo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["NombreUsuario"] != null)
            {
                ViewBag.nombreUsuario = Session["NombreUsuario"].ToString();
                ViewBag.idPerfilUsuario = Session["PerfilUsuario"].ToString();
            }
            return View();
        }
    }
}