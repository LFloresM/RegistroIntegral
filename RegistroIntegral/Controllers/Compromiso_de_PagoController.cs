using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroIntegral.Controllers
{
    public class Compromiso_de_PagoController : Controller
    {
        // GET: Compromiso_de_Pago
        public ActionResult Index()
        {
            return PartialView("Compromiso_de_Pago");
        }
    }
}