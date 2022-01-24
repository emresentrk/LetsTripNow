using Let_sTripNow.Helper;
using Let_sTripNow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Let_sTripNow.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [Route("hakkimizda")]
        public ActionResult Hakkimizda()
        {
            return View();
        }
        [Route("urunler")]
        public ActionResult Urunler()
        {
            FlightSearch flightSearch = new FlightSearch()
            {
                Name = "Emre",
                Flight = "Boeing 737-800",
                Airlines = "THY",
                Gate = 23,
                Seat = "21B",
                Available = true,
                Departure = "İstanbul",
                Landing = "London",
                Date_of_departure = "11/01/2022",
                Date_of_return = "11/02/2022",
                Economy = true,
                Business = false,
                Price = 50,
                Nonstop = true,
                Cancelable = false,
            };

            hDB db = new hDB();
            db.FlightTickets.Add(flightSearch);
            db.SaveChanges();

            return View();
        }
        [Route("neden_biz")]
        public ActionResult Neden_biz()
        {
            return View();
        }
        [Route("Iletisim")]
        public ActionResult Iletisim()
        {
            return View();
        }
        [Route("login")]
        public ActionResult Login()
        {
            return View();
        }
        [Route("Signin")]
        public ActionResult Signin()
        {
            return View();
        }
    }
}