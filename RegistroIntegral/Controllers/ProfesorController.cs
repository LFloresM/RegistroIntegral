using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RegistroIntegral.DAL;

namespace RegistroIntegral.Controllers
{
    public class ProfesorController : Controller
    {
        private RegistroIntegralEntities db = new RegistroIntegralEntities();

        // GET: Profesor
        public ActionResult Index()
        {
            var profesors = db.Profesor.Include(p => p.Persona);
            return PartialView(profesors.ToList());
        }

        // GET: Profesor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesor profesor = db.Profesor.Find(id);
            if (profesor == null)
            {
                return HttpNotFound();
            }
            return View(profesor);
        }

        // GET: Profesor/Create
        public ActionResult Create()
        {
            ViewBag.Per_Id = new SelectList(db.Persona, "Per_Id", "Per_Dni");
            return View();
        }

        // POST: Profesor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Prof_Id,Per_Id,Prof_Rpm,Prof_Nextel,Prof_Especialidad")] Profesor profesor)
        {
            if (ModelState.IsValid)
            {
                db.Profesor.Add(profesor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Per_Id = new SelectList(db.Persona, "Per_Id", "Per_Dni", profesor.Per_Id);
            return View(profesor);
        }

        // GET: Profesor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesor profesor = db.Profesor.Find(id);
            if (profesor == null)
            {
                return HttpNotFound();
            }
            ViewBag.Per_Id = new SelectList(db.Persona, "Per_Id", "Per_Dni", profesor.Per_Id);
            return View(profesor);
        }

        // POST: Profesor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Prof_Id,Per_Id,Prof_Rpm,Prof_Nextel,Prof_Especialidad")] Profesor profesor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profesor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Per_Id = new SelectList(db.Persona, "Per_Id", "Per_Dni", profesor.Per_Id);
            return View(profesor);
        }

        // GET: Profesor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesor profesor = db.Profesor.Find(id);
            if (profesor == null)
            {
                return HttpNotFound();
            }
            return View(profesor);
        }

        // POST: Profesor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Profesor profesor = db.Profesor.Find(id);
            db.Profesor.Remove(profesor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
