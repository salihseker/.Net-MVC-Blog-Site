using Blog_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Blog_MVC.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Kullanici

        SugarBlogContext context = new SugarBlogContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GirisYap(Kullanici kl)
        {
            string ka = ValidateUser(kl.KullaniciAdi, kl.Parola);
            if (!string.IsNullOrEmpty(ka))
            {
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, kl.KullaniciAdi, DateTime.Now, DateTime.Now.AddMinutes(15), true, ka, FormsAuthentication.FormsCookiePath);

                HttpCookie ck = new HttpCookie(FormsAuthentication.FormsCookieName);
                Response.Cookies.Add(ck);

                //if (ticket.IsPersistent)
                //{
                //    ck.Expires = ticket.Expiration;
                //}

                // Response.Redirect(FormsAuthentication.GetRedirectUrl(kl.KullaniciAdi, true));
                FormsAuthentication.RedirectFromLoginPage(kl.KullaniciAdi, true);

                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("GirisYap");
        }

        string ValidateUser(string ka, string pwd)
        {
            Kullanici kl = context.Kullanicis.FirstOrDefault(x => x.KullaniciAdi == ka && x.Parola == pwd);
            if (kl != null)
                return kl.KullaniciAdi;
            else
            {
                return "";
            }
        }

        public ActionResult CikisYap(string redirectUrl)
        {

            FormsAuthentication.SignOut();
            return Redirect(redirectUrl);
        }

        public ActionResult UyeOl()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UyeOl(Kullanici kl , string rdBay , string rdBayan)
        {
            if (!string.IsNullOrEmpty(rdBay))
                kl.Cinsiyet = true;
            if (!string.IsNullOrEmpty(rdBayan))
                kl.Cinsiyet = false;

            kl.Yazar = false;
            kl.Onaylandi = true;
            kl.Aktif = true;
            kl.KayitTarihi = DateTime.Now;
            context.Kullanicis.Add(kl);
            context.SaveChanges();

            Rol yazar = context.Rols.FirstOrDefault(x => x.RolAdi == "Üye");

            KullaniciRol kr = new KullaniciRol();
            kr.RolID = yazar.RolID;
            kr.KullaniciID = kl.KullaniciId;
            context.KullaniciRols.Add(kr);
            context.SaveChanges();

            return RedirectToAction("GirisYap");
        }

    }
}