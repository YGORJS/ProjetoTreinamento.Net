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
    public class AtividadeController : Controller
    {
        private GloboContext db = new GloboContext();

        // GET: Atividade
        public ActionResult Index()
        {
            var atividades = db.Atividades.Include(a => a.funcionario).Include(a => a.programa);
            return View(atividades.ToList());
        }

        // GET: Atividade/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Atividade atividade = db.Atividades.Find(id);
            if (atividade == null)
            {
                return HttpNotFound();
            }
            return View(atividade);
        }

        // GET: Atividade/Create
        public ActionResult Create()
        {
            ViewBag.FuncionarioId = new SelectList(db.Funcionarios, "Id", "Matricula");
            ViewBag.ProgramaId = new SelectList(db.Programas, "Id", "Nome");
            return View();
        }

        // POST: Atividade/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProgramaId,FuncionarioId")] Atividade atividade)
        {
            if (ModelState.IsValid)
            {
                db.Atividades.Add(atividade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FuncionarioId = new SelectList(db.Funcionarios, "Id", "Matricula", atividade.FuncionarioId);
            ViewBag.ProgramaId = new SelectList(db.Programas, "Id", "Nome", atividade.ProgramaId);
            return View(atividade);
        }

        // GET: Atividade/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Atividade atividade = db.Atividades.Find(id);
            if (atividade == null)
            {
                return HttpNotFound();
            }
            ViewBag.FuncionarioId = new SelectList(db.Funcionarios, "Id", "Matricula", atividade.FuncionarioId);
            ViewBag.ProgramaId = new SelectList(db.Programas, "Id", "Nome", atividade.ProgramaId);
            return View(atividade);
        }

        // POST: Atividade/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ProgramaId,FuncionarioId")] Atividade atividade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(atividade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FuncionarioId = new SelectList(db.Funcionarios, "Id", "Matricula", atividade.FuncionarioId);
            ViewBag.ProgramaId = new SelectList(db.Programas, "Id", "Nome", atividade.ProgramaId);
            return View(atividade);
        }

        // GET: Atividade/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Atividade atividade = db.Atividades.Find(id);
            if (atividade == null)
            {
                return HttpNotFound();
            }
            return View(atividade);
        }

        // POST: Atividade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Atividade atividade = db.Atividades.Find(id);
            db.Atividades.Remove(atividade);
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
