﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroIntegral.Controllers
{
    public class FiltroBotonesController : Controller
    {
        // GET: FiltroBotones
        public ActionResult Index()
        {
            return PartialView("FiltroBotones");
        }
    }
}