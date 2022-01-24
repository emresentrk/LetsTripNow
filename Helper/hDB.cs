using Let_sTripNow.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Let_sTripNow.Helper
{
    public class hDB : DbContext
    {
        public hDB() : base("Server=EMRE;Database=DBFlightTicket;Trusted_Connection=True;")
        {

        }

        public DbSet<FlightSearch> FlightTickets { get; set; }
    }
}