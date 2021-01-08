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
    public class InfoBiletsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: InfoBilets
        public ActionResult Index()
        {
            return View(db.InfoBilets.ToList());
        }

        // GET: InfoBilets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InfoBilet infoBilet = db.InfoBilets.Find(id);
            if (infoBilet == null)
            {
                return HttpNotFound();
            }
            return View(infoBilet);
        }

        // GET: InfoBilets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InfoBilets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDbilet,Korisnik,IDvraboten,Cena,Ime_film,Tehnologija,Datum,Vreme_pocnuvanje,Sala,Sediste,Red")] InfoBilet infoBilet)
        {
            if (ModelState.IsValid)
            {
                db.InfoBilets.Add(infoBilet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(infoBilet);
        }

        // GET: InfoBilets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InfoBilet infoBilet = db.InfoBilets.Find(id);
            if (infoBilet == null)
            {
                return HttpNotFound();
            }
            return View(infoBilet);
        }

        // POST: InfoBilets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDbilet,Korisnik,IDvraboten,Cena,Ime_film,Tehnologija,Datum,Vreme_pocnuvanje,Sala,Sediste,Red")] InfoBilet infoBilet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(infoBilet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(infoBilet);
        }

        // GET: InfoBilets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InfoBilet infoBilet = db.InfoBilets.Find(id);
            if (infoBilet == null)
            {
                return HttpNotFound();
            }
            return View(infoBilet);
        }

        // POST: InfoBilets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InfoBilet infoBilet = db.InfoBilets.Find(id);
            db.InfoBilets.Remove(infoBilet);
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
