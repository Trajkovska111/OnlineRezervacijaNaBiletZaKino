using OnlineRezNaBiletZaKino.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineRezNaBiletZaKino.Models
{
    public class AkteriController : Controller
    {
        ApplicationDbContext context;

        public AkteriController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Akteri
        public ActionResult Index()
        {
            return View(context.Akteri.ToList());
        }
    }
}