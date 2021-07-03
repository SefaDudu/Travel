using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Models.Sınıflar;

namespace Travel.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context context = new Context();

        public ActionResult Index()
        {
            var result = context.Hakkimizdas.ToList();
            return View(result);
        }
    }
}