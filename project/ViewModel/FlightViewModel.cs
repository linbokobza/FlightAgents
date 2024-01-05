using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using project.Models;

namespace project.ViewModel
{
    public class FlightViewModel
    {
        public Flight ShowFlight {get; set;}
        public List<Flight> ShowFlights { get; set; }
    }
}