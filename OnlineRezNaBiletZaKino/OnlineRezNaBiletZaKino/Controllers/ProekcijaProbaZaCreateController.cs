using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineRezNaBiletZaKino.DataContext;
using OnlineRezNaBiletZaKino.Models;

namespace OnlineRezNaBiletZaKino.Controllers
{
    public class ProekcijaProbaZaCreateController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ProekcijaProbaZaCreate
        public ActionResult Index()
        {
            return View(db.Proekcii.ToList());
        }

        // GET: ProekcijaProbaZaCreate/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proekcija proekcija = db.Proekcii.Find(id);
            if (proekcija == null)
            {
                return HttpNotFound();
            }
            return View(proekcija);
        }

        // GET: ProekcijaProbaZaCreate/Create
        public ActionResult NovaProekcija()
        {
            return View();
        }

        // POST: ProekcijaProbaZaCreate/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NovaProekcija([Bind(Include = "id_proekcija,id_film,vreme_pocetok,vreme_kraj")] Proekcija proekcija)
        {
            if (ModelState.IsValid)
            {
                db.Proekcii.Add(proekcija);
                db.SaveChanges();
                return RedirectToAction("NovoSeProektiraVo", "Se_proektira_vo");
            }

            return View(proekcija);
        }

        // GET: ProekcijaProbaZaCreate/Edit/5
        public ActionResult Edit(int? id_p, int? id_f)
        {
            Proekcija proekcija = db.Proekcii.Find(id_p, id_f);
            if (proekcija == null)
            {
                return HttpNotFound();
            }
            return View(proekcija);
        }

        // POST: ProekcijaProbaZaCreate/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_proekcija,id_film,vreme_pocetok,vreme_kraj")] Proekcija proekcija)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proekcija).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(proekcija);
        }

        // GET: ProekcijaProbaZaCreate/Delete/5
        public ActionResult Delete(int? id_p, int? id_f)
        {

            Proekcija proekcija = db.Proekcii.Find(id_p, id_f);
            if (proekcija == null)
            {
                return HttpNotFound();
            }
            return View(proekcija);
        }

        // POST: ProekcijaProbaZaCreate/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id_p, int id_f)
        {
            Proekcija proekcija = db.Proekcii.Find(id_p,id_f);
            db.Proekcii.Remove(proekcija);
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
