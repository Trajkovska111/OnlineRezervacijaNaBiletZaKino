using OnlineRezNaBiletZaKino.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineRezNaBiletZaKino.Controllers
{
    public class NajredovenKorisnikController : Controller
    {
        ApplicationDbContext context;

        public NajredovenKorisnikController()
        {
            context = new ApplicationDbContext();
        }
        // GET: NajredovenKorisnik
        public ActionResult NajredovenKorisnik()
        {
            return View(context.NajredovniKorisnici.ToList());
        }
    }
}