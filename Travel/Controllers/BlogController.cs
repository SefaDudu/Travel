using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Models.Sınıflar;

namespace Travel.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context context = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            //var result = context.Blogs.ToList();
            by.Deger1 = context.Blogs.ToList();
            by.Deger3 = context.Blogs.OrderByDescending(x => x.Id).Take(3).ToList();//son blogları yapmak için sondan 2 tane göstermek istedik
            return View(by);
        }

        public ActionResult BlogDetay(int id)
        {
            //var blogbul = context.Blogs.Where(x => x.Id == id).ToList();
            by.Deger1 = context.Blogs.Where(x => x.Id == id).ToList();//burası resimlerin gelmesi için
            by.Deger2 = context.Yorumlars.Where(x => x.BlogId == id).ToList();//burası yorumların gelmesi için
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;

            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            context.Yorumlars.Add(y);
            context.SaveChanges();
            return PartialView();
        }
    }
}