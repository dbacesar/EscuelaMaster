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

    public class TblUsuariosController : Controller
    {
        private EscuelaMasterEntities db = new EscuelaMasterEntities();

        // GET: TblUsuarios
        public ActionResult Index()
        {
            return View(db.TblUsuario.ToList());
        }

        // GET: TblUsuarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblUsuario tblUsuario = db.TblUsuario.Find(id);
            if (tblUsuario == null)
            {
                return HttpNotFound();
            }
            return View(tblUsuario);
        }

        // GET: TblUsuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TblUsuarios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UsuarioID,NombreUsuario,ClaveUsuario,TelefonoUsuario")] TblUsuario tblUsuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.TblUsuario.Add(tblUsuario);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(tblUsuario);
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }

            return View("error");
                
        }

        // GET: TblUsuarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblUsuario tblUsuario = db.TblUsuario.Find(id);
            if (tblUsuario == null)
            {
                return HttpNotFound();
            }
            return View(tblUsuario);
        }

        // POST: TblUsuarios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UsuarioID,NombreUsuario,ClaveUsuario,TelefonoUsuario")] TblUsuario tblUsuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblUsuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblUsuario);
        }

        // GET: TblUsuarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblUsuario tblUsuario = db.TblUsuario.Find(id);
            if (tblUsuario == null)
            {
                return HttpNotFound();
            }
            return View(tblUsuario);
        }

        // POST: TblUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TblUsuario tblUsuario = db.TblUsuario.Find(id);
            db.TblUsuario.Remove(tblUsuario);
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
