using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proyecto.MVC.DAL;

namespace Proyecto.MVC.Controllers
{
    public class tipo_incidenciaController : Controller
    {
        private bdGeneralEntities db = new bdGeneralEntities();

        // GET: tipo_incidencia
        public ActionResult Index()
        {
            return View(db.tipo_incidencia.ToList());
        }

        // GET: tipo_incidencia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tipo_incidencia tipo_incidencia = db.tipo_incidencia.Find(id);
            if (tipo_incidencia == null)
            {
                return HttpNotFound();
            }
            return View(tipo_incidencia);
        }

        // GET: tipo_incidencia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tipo_incidencia/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,descripcion")] tipo_incidencia tipo_incidencia)
        {
            if (ModelState.IsValid)
            {
                db.tipo_incidencia.Add(tipo_incidencia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipo_incidencia);
        }

        // GET: tipo_incidencia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tipo_incidencia tipo_incidencia = db.tipo_incidencia.Find(id);
            if (tipo_incidencia == null)
            {
                return HttpNotFound();
            }
            return View(tipo_incidencia);
        }

        // POST: tipo_incidencia/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,descripcion")] tipo_incidencia tipo_incidencia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipo_incidencia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipo_incidencia);
        }

        // GET: tipo_incidencia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tipo_incidencia tipo_incidencia = db.tipo_incidencia.Find(id);
            if (tipo_incidencia == null)
            {
                return HttpNotFound();
            }
            return View(tipo_incidencia);
        }

        // POST: tipo_incidencia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tipo_incidencia tipo_incidencia = db.tipo_incidencia.Find(id);
            db.tipo_incidencia.Remove(tipo_incidencia);
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
