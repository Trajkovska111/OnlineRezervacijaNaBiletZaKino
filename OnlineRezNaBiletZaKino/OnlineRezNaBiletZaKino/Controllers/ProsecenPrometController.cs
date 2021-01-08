using OnlineRezNaBiletZaKino.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineRezNaBiletZaKino.Controllers
{
    public class ProsecenPrometController : Controller
    {
        ApplicationDbContext context;

        public ProsecenPrometController()
        {
            context = new ApplicationDbContext();
        }
        // GET: ProsecenPromet
        public ActionResult ProsecenPromet()
        {
            return View(context.ProsecenPromets.ToList());
        }
    }
}