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
        private ConsultoriaIdentityRolesContext db = new ConsultoriaIdentityRolesContext();

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
            ReunionesModel reunionesModel = db.ReunionesModels.Find(id);
            if (reunionesModel == null)
            {
                return HttpNotFound();
            }
            return View(reunionesModel);
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
        public ActionResult Create([Bind(Include = "id,Nombre,Correo,Telefono,Compania,FechaHora,Razon")] ReunionesModel reunionesModel)
        {
            if (ModelState.IsValid)
            {
                db.ReunionesModels.Add(reunionesModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reunionesModel);
        }

        // GET: ReunionesModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReunionesModel reunionesModel = db.ReunionesModels.Find(id);
            if (reunionesModel == null)
            {
                return HttpNotFound();
            }
            return View(reunionesModel);
        }

        // POST: ReunionesModels/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Nombre,Correo,Telefono,Compania,FechaHora,Razon")] ReunionesModel reunionesModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reunionesModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reunionesModel);
        }

        // GET: ReunionesModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReunionesModel reunionesModel = db.ReunionesModels.Find(id);
            if (reunionesModel == null)
            {
                return HttpNotFound();
            }
            return View(reunionesModel);
        }

        // POST: ReunionesModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReunionesModel reunionesModel = db.ReunionesModels.Find(id);
            db.ReunionesModels.Remove(reunionesModel);
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
