using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Let_sTripNow.Helper;
using Let_sTripNow.Models;

namespace Let_sTripNow.Controllers
{
    public class TicketController : Controller
    {
        private hDB db = new hDB();

        // GET: Ticket
        public ActionResult Index()
        {
            return View(db.FlightTickets.ToList());
        }

        // GET: Ticket/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FlightSearch flightSearch = db.FlightTickets.Find(id);
            if (flightSearch == null)
            {
                return HttpNotFound();
            }
            return View(flightSearch);
        }

        // GET: Ticket/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ticket/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Flight,Airlines,Gate,Seat,Available,Departure,Landing,Date_of_departure,Date_of_return,Economy,Business,Price,Nonstop,Cancelable")] FlightSearch flightSearch)
        {
            if (ModelState.IsValid)
            {
                db.FlightTickets.Add(flightSearch);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(flightSearch);
        }

        // GET: Ticket/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FlightSearch flightSearch = db.FlightTickets.Find(id);
            if (flightSearch == null)
            {
                return HttpNotFound();
            }
            return View(flightSearch);
        }

        // POST: Ticket/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Flight,Airlines,Gate,Seat,Available,Departure,Landing,Date_of_departure,Date_of_return,Economy,Business,Price,Nonstop,Cancelable")] FlightSearch flightSearch)
        {
            if (ModelState.IsValid)
            {
                db.Entry(flightSearch).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(flightSearch);
        }

        // GET: Ticket/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FlightSearch flightSearch = db.FlightTickets.Find(id);
            if (flightSearch == null)
            {
                return HttpNotFound();
            }
            return View(flightSearch);
        }

        // POST: Ticket/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FlightSearch flightSearch = db.FlightTickets.Find(id);
            db.FlightTickets.Remove(flightSearch);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
