using System;
using System.Collections.Generic;
using System.Linq;
 
using System.Web;
using System.Web.Mvc;
using Travel.Models.Sınıflar;

namespace Travel.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        
        public ActionResult Index()
        {
            var result = c.Blogs.Take(4).ToList();
            return View(result);
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x=>x.Id).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var deger = c.Blogs.OrderByDescending(x => x.Id).Take(1);
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var deger = c.Blogs.OrderByDescending(x=> x.Id).Take(3).ToList();
            return PartialView(deger);
        }
    }
}