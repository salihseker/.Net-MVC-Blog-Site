using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_MVC.Controllers
{
    using Models;
    public class YazarController : Controller
    {
        // GET: Yazar
        SugarBlogContext context = new SugarBlogContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult YazarOl()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YazarOl(Kullanici kl, string rdBay, string rdBayan)
        {
            if (!string.IsNullOrEmpty(rdBay))
                kl.Cinsiyet = true;
            if (!string.IsNullOrEmpty(rdBayan))
                kl.Cinsiyet = false;

            kl.Yazar = true;
            kl.Onaylandi = false;
            kl.Aktif = true;
            kl.KayitTarihi = DateTime.Now;
            context.Kullanicis.Add(kl);
            context.SaveChanges();

            Rol yazar = context.Rols.FirstOrDefault(x => x.RolAdi == "Yazar");

            KullaniciRol kr = new KullaniciRol();
            kr.RolID = yazar.RolID;
            kr.KullaniciID = kl.KullaniciId;
            context.KullaniciRols.Add(kr);
            context.SaveChanges();

            return RedirectToAction("Index","Home");
        }
    }
}