using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_MVC.Controllers
{
    using Models;
    using App_Classes;
    public class HomeController : Controller
    {
        SugarBlogContext context = new SugarBlogContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MakaleListele() {
            var data = context.Makales.ToList();
            return View("MakaleListeleWidget", data);
        }
        public PartialViewResult PopulerMakalelerWidget() {
            var model = context.Makales.OrderByDescending(x => x.EklenmeTarihi).Take(3).ToList();
            return PartialView(model);
        }
    }
}