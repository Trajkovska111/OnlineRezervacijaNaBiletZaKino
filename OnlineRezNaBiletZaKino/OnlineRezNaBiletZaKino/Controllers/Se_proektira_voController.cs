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
    public class Se_proektira_voController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Se_proektira_vo
        public ActionResult Index()
        {
            return View(db.Se_Proektira_Vos.ToList());
        }

        // GET: Se_proektira_vo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Se_proektira_vo se_proektira_vo = db.Se_Proektira_Vos.Find(id);
            if (se_proektira_vo == null)
            {
                return HttpNotFound();
            }
            return View(se_proektira_vo);
        }

        // GET: Se_proektira_vo/Create
        public ActionResult NovoSeProektiraVo()
        {
            return View();
        }

        // POST: Se_proektira_vo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NovoSeProektiraVo([Bind(Include = "id_proekcija,id_film,broj_sala")] Se_proektira_vo se_proektira_vo)
        {
            if (ModelState.IsValid)
            {
                db.Se_Proektira_Vos.Add(se_proektira_vo);
                db.SaveChanges();
                return RedirectToAction("Index", "Film");
            }

            return View(se_proektira_vo);
        }

        // GET: Se_proektira_vo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Se_proektira_vo se_proektira_vo = db.Se_Proektira_Vos.Find(id);
            if (se_proektira_vo == null)
            {
                return HttpNotFound();
            }
            return View(se_proektira_vo);
        }

        // POST: Se_proektira_vo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_proekcija,id_film,broj_sala")] Se_proektira_vo se_proektira_vo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(se_proektira_vo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(se_proektira_vo);
        }

        // GET: Se_proektira_vo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Se_proektira_vo se_proektira_vo = db.Se_Proektira_Vos.Find(id);
            if (se_proektira_vo == null)
            {
                return HttpNotFound();
            }
            return View(se_proektira_vo);
        }

        // POST: Se_proektira_vo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Se_proektira_vo se_proektira_vo = db.Se_Proektira_Vos.Find(id);
            db.Se_Proektira_Vos.Remove(se_proektira_vo);
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
