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
    public class BILETController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BILET
        public ActionResult Index()
        {
            return View(db.BILETs.ToList());
        }

        // GET: BILET/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BILET bILET = db.BILETs.Find(id);
            if (bILET == null)
            {
                return HttpNotFound();
            }
            return View(bILET);
        }

        // GET: BILET/Create
        public ActionResult Rezervacija() //tuka treba da dobijan id na film i id na proekcija 
        {
            return View();
        }

        // POST: BILET/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Rezervacija([Bind(Include = "id_bilet,cena,e_mail,vreme_na_rezervacija,id_proekcija,id_film,broj_sala,broj_sediste,broj_red")] BILET bILET)
        {
            if (ModelState.IsValid)
            {
                db.BILETs.Add(bILET);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bILET);
        }

        // GET: BILET/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BILET bILET = db.BILETs.Find(id);
            if (bILET == null)
            {
                return HttpNotFound();
            }
            return View(bILET);
        }

        // POST: BILET/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_bilet,cena,e_mail,vreme_na_rezervacija,id_proekcija,id_film,broj_sala,broj_sediste,broj_red")] BILET bILET)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bILET).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bILET);
        }

        // GET: BILET/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BILET bILET = db.BILETs.Find(id);
            if (bILET == null)
            {
                return HttpNotFound();
            }
            return View(bILET);
        }

        // POST: BILET/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BILET bILET = db.BILETs.Find(id);
            db.BILETs.Remove(bILET);
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
