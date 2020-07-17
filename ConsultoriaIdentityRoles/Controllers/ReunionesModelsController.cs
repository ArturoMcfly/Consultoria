using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ConsultoriaIdentityRoles.Data;
using ConsultoriaIdentityRoles.Models;

namespace ConsultoriaIdentityRoles.Controllers
{
    public class ReunionesModelsController : Controller
    {
        private ConsultoriaIdentityRolesRMContext db = new ConsultoriaIdentityRolesRMContext();

        // GET: ReunionesModels
        public ActionResult Index()
        {
            return View(db.ReunionesModels.ToList());
        }

        // GET: ReunionesModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReunionesModels reunionesModels = db.ReunionesModels.Find(id);
            if (reunionesModels == null)
            {
                return HttpNotFound();
            }
            return View(reunionesModels);
        }

        // GET: ReunionesModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReunionesModels/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Correo,Telefono,Compania,FechaHora,Razon")] ReunionesModels reunionesModels)
        {
            if (ModelState.IsValid)
            {
                db.ReunionesModels.Add(reunionesModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reunionesModels);
        }

        // GET: ReunionesModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReunionesModels reunionesModels = db.ReunionesModels.Find(id);
            if (reunionesModels == null)
            {
                return HttpNotFound();
            }
            return View(reunionesModels);
        }

        // POST: ReunionesModels/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Correo,Telefono,Compania,FechaHora,Razon")] ReunionesModels reunionesModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reunionesModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reunionesModels);
        }

        // GET: ReunionesModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReunionesModels reunionesModels = db.ReunionesModels.Find(id);
            if (reunionesModels == null)
            {
                return HttpNotFound();
            }
            return View(reunionesModels);
        }

        // POST: ReunionesModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReunionesModels reunionesModels = db.ReunionesModels.Find(id);
            db.ReunionesModels.Remove(reunionesModels);
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
