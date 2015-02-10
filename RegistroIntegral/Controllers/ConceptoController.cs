using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroIntegral.Controllers
{
    public class ConceptoController : Controller
    {
        // GET: Concepto
        public ActionResult Index()
        {
            return PartialView("Concepto");
        }
    }
}