using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_MVC.Controllers
{
    using Models;
    public class EtiketController : Controller
    {
        SugarBlogContext context = new SugarBlogContext();
        // GET: Etiket
        public ActionResult Index(int id)
        {
            return View(id);
        }

        public PartialViewResult EtiketWidget()
        {

            return PartialView(context.Etikets.ToList());
        }

        public ActionResult MakaleListele(int id)
        {
            var data = context.Makales.Where(x => x.Etikets.Any(y => y.EtiketId == id)).ToList();
            return View("MakaleListeleWidget" , data);
        }
    }
}