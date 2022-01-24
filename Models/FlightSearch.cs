using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Let_sTripNow.Models
{
    public class FlightSearch
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Flight { get; set; }
        public string Airlines{ get; set; }
        public int Gate { get; set; }
        public string Seat { get; set; }
        public bool Available { get; set; }
        public string Departure { get; set; }
        public string Landing { get; set; }
        public string Date_of_departure { get; set; } 
        public string Date_of_return { get; set; }
        public bool Economy { get; set; }
        public bool Business { get; set; }
        public double Price { get; set; }
        public bool Nonstop { get; set; }
        public bool Cancelable { get; set; }
    }
}