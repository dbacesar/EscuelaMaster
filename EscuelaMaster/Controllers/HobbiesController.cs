using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EscuelaMaster.Models;

namespace EscuelaMaster.Controllers
{
    public class HobbiesController : Controller
    {
        private EscuelaMasterEntities db = new EscuelaMasterEntities();

        // GET: Hobbies
        public ActionResult Index()
        {
            return View(db.Hobbies.ToList());
        }

        // GET: Hobbies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hobbies hobbies = db.Hobbies.Find(id);
            if (hobbies == null)
            {
                return HttpNotFound();
            }
            return View(hobbies);
        }

        // GET: Hobbies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hobbies/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HobbieID,NombreHobbie")] Hobbies hobbies)
        {
            if (ModelState.IsValid)
            {
                db.Hobbies.Add(hobbies);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hobbies);
        }

        // GET: Hobbies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hobbies hobbies = db.Hobbies.Find(id);
            if (hobbies == null)
            {
                return HttpNotFound();
            }
            return View(hobbies);
        }

        // POST: Hobbies/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HobbieID,NombreHobbie")] Hobbies hobbies)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hobbies).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hobbies);
        }

        // GET: Hobbies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hobbies hobbies = db.Hobbies.Find(id);
            if (hobbies == null)
            {
                return HttpNotFound();
            }
            return View(hobbies);
        }

        // POST: Hobbies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hobbies hobbies = db.Hobbies.Find(id);
            db.Hobbies.Remove(hobbies);
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
