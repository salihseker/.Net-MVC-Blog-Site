using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_MVC.Controllers
{
    using Models;
    public class AdminController : Controller
    {

        // GET: Admin
        SugarBlogContext context = new SugarBlogContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult YazarOnaylari()
        {
            var data = context.Kullanicis.Where(x => x.Yazar == true && x.Onaylandi == false).ToList();
            return View(data);
        }

        public ActionResult OnayVer(int id)
        {
            Kullanici kl = context.Kullanicis.FirstOrDefault(x => x.KullaniciId == id);
            kl.Onaylandi = true;
            context.SaveChanges();
            return RedirectToAction("YazarOnaylari");
        }
    }
}