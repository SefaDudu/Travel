using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Models.Sınıflar;

namespace Travel.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
        public ActionResult Index()
        {
            var result = c.Blogs.ToList();
            return View(result);
        }
        [HttpGet]
        public ActionResult YeniBlog() //HTTP GET için çalışır
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)//HTTP POST İÇİN ÇALIŞIR
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var b = c.Blogs.Find(id);
            return View("BlogGetir",b);
        }
        public ActionResult BlogGuncelle(Blog p )
        {
            var b = c.Blogs.Find(p.Id);
            b.Aciklama = p.Aciklama;
            b.Baslik = p.Baslik;
            b.BlogImage = p.BlogImage;
            b.Tarih = p.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}