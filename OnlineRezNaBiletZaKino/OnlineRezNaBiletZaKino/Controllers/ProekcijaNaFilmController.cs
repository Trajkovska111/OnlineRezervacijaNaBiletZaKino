using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineRezNaBiletZaKino.Models;
using OnlineRezNaBiletZaKino.DataContext;


namespace OnlineRezNaBiletZaKino.Controllers
{

    
    public class ProekcijaNaFilmController : Controller
    {
        ApplicationDbContext context;

        public ProekcijaNaFilmController()
        {
            context = new ApplicationDbContext();
        }
        // GET: ProekcijaNaFilm
        public ActionResult Index()
        {
            return View(context.Proekcii_filmovi.ToList());
        }
    }
}