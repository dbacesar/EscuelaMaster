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
    public class TblHobbiesUsuariosController : Controller
    {
        private EscuelaMasterEntities db = new EscuelaMasterEntities();

        // GET: TblHobbiesUsuarios
        public ActionResult Index()
        {
            var tblHobbiesUsuario = db.TblHobbiesUsuario.Include(t => t.Hobbies).Include(t => t.TblUsuario);
            return View(tblHobbiesUsuario.ToList());
        }

        // GET: TblHobbiesUsuarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblHobbiesUsuario tblHobbiesUsuario = db.TblHobbiesUsuario.Find(id);
            if (tblHobbiesUsuario == null)
            {
                return HttpNotFound();
            }
            return View(tblHobbiesUsuario);
        }

        // GET: TblHobbiesUsuarios/Create
        public ActionResult Create()
        {
            ViewBag.HobbieID = new SelectList(db.Hobbies, "HobbieID", "NombreHobbie");
            ViewBag.UsuarioID = new SelectList(db.TblUsuario, "UsuarioID", "NombreUsuario");
            return View();
        }

        // POST: TblHobbiesUsuarios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HobbiesUsuario,UsuarioID,HobbieID")] TblHobbiesUsuario tblHobbiesUsuario)
        {
            if (ModelState.IsValid)
            {
                db.TblHobbiesUsuario.Add(tblHobbiesUsuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.HobbieID = new SelectList(db.Hobbies, "HobbieID", "NombreHobbie", tblHobbiesUsuario.HobbieID);
            ViewBag.UsuarioID = new SelectList(db.TblUsuario, "UsuarioID", "NombreUsuario", tblHobbiesUsuario.UsuarioID);
            return View(tblHobbiesUsuario);
        }

        // GET: TblHobbiesUsuarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblHobbiesUsuario tblHobbiesUsuario = db.TblHobbiesUsuario.Find(id);
            if (tblHobbiesUsuario == null)
            {
                return HttpNotFound();
            }
            ViewBag.HobbieID = new SelectList(db.Hobbies, "HobbieID", "NombreHobbie", tblHobbiesUsuario.HobbieID);
            ViewBag.UsuarioID = new SelectList(db.TblUsuario, "UsuarioID", "NombreUsuario", tblHobbiesUsuario.UsuarioID);
            return View(tblHobbiesUsuario);
        }

        // POST: TblHobbiesUsuarios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HobbiesUsuario,UsuarioID,HobbieID")] TblHobbiesUsuario tblHobbiesUsuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblHobbiesUsuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HobbieID = new SelectList(db.Hobbies, "HobbieID", "NombreHobbie", tblHobbiesUsuario.HobbieID);
            ViewBag.UsuarioID = new SelectList(db.TblUsuario, "UsuarioID", "NombreUsuario", tblHobbiesUsuario.UsuarioID);
            return View(tblHobbiesUsuario);
        }

        // GET: TblHobbiesUsuarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblHobbiesUsuario tblHobbiesUsuario = db.TblHobbiesUsuario.Find(id);
            if (tblHobbiesUsuario == null)
            {
                return HttpNotFound();
            }
            return View(tblHobbiesUsuario);
        }

        // POST: TblHobbiesUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TblHobbiesUsuario tblHobbiesUsuario = db.TblHobbiesUsuario.Find(id);
            db.TblHobbiesUsuario.Remove(tblHobbiesUsuario);
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
