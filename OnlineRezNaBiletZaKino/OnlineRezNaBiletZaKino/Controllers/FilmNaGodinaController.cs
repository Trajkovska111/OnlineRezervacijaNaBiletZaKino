using OnlineRezNaBiletZaKino.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineRezNaBiletZaKino.Controllers
{
    public class FilmNaGodinaController : Controller
    {
        ApplicationDbContext context;

        public FilmNaGodinaController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Akteri
        public ActionResult Index()
        {
            return View(context.FilmoviNaGodinata.ToList());
        }
    }
}