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
    public class CategoriaProgramaController : Controller
    {
        private GloboContext db = new GloboContext();

        // GET: CategoriaPrograma
        public ActionResult Index()
        {
            return View(db.CategoriaProgramas.ToList());
        }

        // GET: CategoriaPrograma/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaPrograma categoriaPrograma = db.CategoriaProgramas.Find(id);
            if (categoriaPrograma == null)
            {
                return HttpNotFound();
            }
            return View(categoriaPrograma);
        }

        // GET: CategoriaPrograma/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaPrograma/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Descricao,Status,DtIncl,DtAtlz")] CategoriaPrograma categoriaPrograma)
        {
            if (ModelState.IsValid)
            {
                db.CategoriaProgramas.Add(categoriaPrograma);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoriaPrograma);
        }

        // GET: CategoriaPrograma/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaPrograma categoriaPrograma = db.CategoriaProgramas.Find(id);
            if (categoriaPrograma == null)
            {
                return HttpNotFound();
            }
            return View(categoriaPrograma);
        }

        // POST: CategoriaPrograma/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Descricao,Status,DtIncl,DtAtlz")] CategoriaPrograma categoriaPrograma)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoriaPrograma).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoriaPrograma);
        }

        // GET: CategoriaPrograma/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaPrograma categoriaPrograma = db.CategoriaProgramas.Find(id);
            if (categoriaPrograma == null)
            {
                return HttpNotFound();
            }
            return View(categoriaPrograma);
        }

        // POST: CategoriaPrograma/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoriaPrograma categoriaPrograma = db.CategoriaProgramas.Find(id);
            db.CategoriaProgramas.Remove(categoriaPrograma);
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
