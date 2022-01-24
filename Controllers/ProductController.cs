using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Let_sTripNow.Controllers
{
    public class ProductController : Controller
    {
        // GET: Urun
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UcakBilet()
        {
            return View();
        }
    }
}