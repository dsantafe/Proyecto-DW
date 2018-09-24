using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.MVC.Controllers
{
    public class EstadoIncidenciaController : Controller
    {
        // GET: EstadoIncidencia
        public ActionResult Index()
        {
            BL.clsEstadoIncidencia obclsEstadoIncidencia = new BL.clsEstadoIncidencia();

            return View(obclsEstadoIncidencia.GetEstadoIncidencia());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.EstadoIncidencia estado_indicencia)
        {
            if (ModelState.IsValid)
            {
                BL.clsEstadoIncidencia obclsEstadoIncidencia = new BL.clsEstadoIncidencia();
                obclsEstadoIncidencia.CreateEstadoIncidencia(estado_indicencia);
                return RedirectToAction("Index");
            }

            return View(estado_indicencia);
        }

        public ActionResult Edit(int id)
        {
            BL.clsEstadoIncidencia obclsEstadoIncidencia = new BL.clsEstadoIncidencia();
            Models.EstadoIncidencia estado_incidencia = obclsEstadoIncidencia.GetEstadoIncidencia(new Models.EstadoIncidencia { Id = id }).FirstOrDefault();

            return View(estado_incidencia);
        }

        [HttpPost]
        public ActionResult Edit(Models.EstadoIncidencia estado_indicencia)
        {
            if (ModelState.IsValid)
            {
                BL.clsEstadoIncidencia obclsEstadoIncidencia = new BL.clsEstadoIncidencia();
                obclsEstadoIncidencia.UpdateEstadoIncidencia(estado_indicencia);
                return RedirectToAction("Index");
            }

            return View(estado_indicencia);
        }

        public ActionResult Delete(int id)
        {
            BL.clsEstadoIncidencia obclsEstadoIncidencia = new BL.clsEstadoIncidencia();
            Models.EstadoIncidencia estado_incidencia = obclsEstadoIncidencia.GetEstadoIncidencia(new Models.EstadoIncidencia { Id = id }).FirstOrDefault();

            if (estado_incidencia == null)
                return HttpNotFound();

            return View(estado_incidencia);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Models.EstadoIncidencia estado_incidencia)
        {
            BL.clsEstadoIncidencia obclsEstadoIncidencia = new BL.clsEstadoIncidencia();
            obclsEstadoIncidencia.DeleteEstadoIncidencia(estado_incidencia);

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            BL.clsEstadoIncidencia obclsEstadoIncidencia = new BL.clsEstadoIncidencia();
            Models.EstadoIncidencia estado_incidencia = obclsEstadoIncidencia.GetEstadoIncidencia(new Models.EstadoIncidencia { Id = id }).FirstOrDefault();

            if (estado_incidencia == null)
                return HttpNotFound();

            return View(estado_incidencia);
        }
    }
}