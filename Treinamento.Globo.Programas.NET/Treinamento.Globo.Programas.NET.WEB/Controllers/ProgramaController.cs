using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dominio;
using Treinamento.Globo.Programas.NET.WEB.DAL;

namespace Treinamento.Globo.Programas.NET.WEB.Controllers
{
    public class ProgramaController : Controller
    {
        private GloboContext db = new GloboContext();

        // GET: Programa
        public ActionResult Index()
        {
            var programas = db.Programas.Include(p => p.CategoriaPrograma);
            return View(programas.ToList());
        }

        // GET: Programa/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Programa programa = db.Programas.Find(id);
            if (programa == null)
            {
                return HttpNotFound();
            }
            return View(programa);
        }

        // GET: Programa/Create
        public ActionResult Create()
        {
            ViewBag.CategoriaProgramaId = new SelectList(db.CategoriaProgramas, "Id", "Nome");
            return View();
        }

        // POST: Programa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Horario,DtIncl,DtAtlz,Status,CategoriaProgramaId")] Programa programa)
        {
            if (ModelState.IsValid)
            {
                db.Programas.Add(programa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoriaProgramaId = new SelectList(db.CategoriaProgramas, "Id", "Nome", programa.CategoriaProgramaId);
            return View(programa);
        }

        // GET: Programa/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Programa programa = db.Programas.Find(id);
            if (programa == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoriaProgramaId = new SelectList(db.CategoriaProgramas, "Id", "Nome", programa.CategoriaProgramaId);
            return View(programa);
        }

        // POST: Programa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Horario,DtIncl,DtAtlz,Status,CategoriaProgramaId")] Programa programa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(programa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoriaProgramaId = new SelectList(db.CategoriaProgramas, "Id", "Nome", programa.CategoriaProgramaId);
            return View(programa);
        }

        // GET: Programa/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Programa programa = db.Programas.Find(id);
            if (programa == null)
            {
                return HttpNotFound();
            }
            return View(programa);
        }

        // POST: Programa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Programa programa = db.Programas.Find(id);
            db.Programas.Remove(programa);
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
