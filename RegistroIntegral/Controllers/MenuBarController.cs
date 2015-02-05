using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroIntegral.Controllers
{
    public class MenuBarController : Controller
    {
        // GET: MenuBar
        public ActionResult Index()
        {
            return PartialView("MenuBar");
        }
    }
}