using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_MVC.Controllers
{
    using Models;
    public class KategoriController : Controller
    {
        SugarBlogContext context = new SugarBlogContext();
        // GET: Kategori
        public ActionResult Index(int id)
        {
            return View(id);
        }

        public PartialViewResult KategoriWidget()
        {

            return PartialView(context.Kategoris.ToList());
        }

        public ActionResult MakaleListele(int id)
        {
            var data = context.Makales.Where(x => x.KategoriID == id).ToList();
            return View("MakaleListeleWidget",data);
        }
    }
}