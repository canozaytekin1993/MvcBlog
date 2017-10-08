using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBlog.Models;

namespace MvcBlog.Controllers
{
    public class HomeController : Controller
    {
        mvcblogDB db = new mvcblogDB();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hakkimizda()
        {
            return View();
        }

        public ActionResult Iletisim()
        {
            return View();
        }

        public ActionResult KategoriPartial()
        {
            return View(db.Kategoris.ToList());
        }
    }
}