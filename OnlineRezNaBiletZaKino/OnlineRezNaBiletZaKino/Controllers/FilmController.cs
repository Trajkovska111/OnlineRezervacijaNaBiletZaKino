using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineRezNaBiletZaKino.Models;
using OnlineRezNaBiletZaKino.DataContext;
using System.Net;

namespace OnlineRezNaBiletZaKino.Controllers
{
    public class FilmController : Controller
    {
        ApplicationDbContext context;
        public FilmController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Film
        public ActionResult Index()
        {
            return View(context.Filmovi_info.ToList());
        }

        public ActionResult ProekciiNaFilm(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            List<ProekcijaNaFilm> proekcii = context.Proekcii_filmovi.Where(f => f.id_film == id).ToList();
            if (proekcii == null)
            {
                return HttpNotFound();
            }
            return View(proekcii);
        }

        public ActionResult NovFilm()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NovFilm([Bind(Include = "id_film,ime_film,reziser,vremetraenje,zanr,tehnologija,film_url,vozrasna_kategorija")] Film film)
        {
            if (ModelState.IsValid)
            {
                context.Filmovi_info.Add(film);
                context.SaveChanges();
                return RedirectToAction("NovaProekcija","ProekcijaProbaZaCreate");
            }

            return View(film);
        }

        public ActionResult Delete(int? id)
        {
            Film film = context.Filmovi_info.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // POST: ProekcijaProbaZaCreate/Delete/5
       // [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Film film = context.Filmovi_info.Find(id);
            context.Filmovi_info.Remove(film);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}