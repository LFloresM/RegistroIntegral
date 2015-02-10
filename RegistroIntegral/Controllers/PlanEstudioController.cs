using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroIntegral.Controllers
{
    public class PlanEstudioController : Controller
    {
        // GET: PlanEstudio
        public ActionResult Index()
        {
            return PartialView("PlanEstudio");
        }
    }
}