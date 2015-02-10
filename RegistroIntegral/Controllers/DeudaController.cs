using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroIntegral.Controllers
{
    public class DeudaController : Controller
    {
        // GET: Deuda
        public ActionResult Index()
        {
            return PartialView("Deuda");
        }
    }
}