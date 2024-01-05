using project.dal;
using project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project.ViewModel;
using System.Web.UI;
using System.Data.Entity;

namespace project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Context dal = new Context();
            FlightViewModel f = new FlightViewModel();
            List<Flight> fl = (from x in dal.flights where x.DeparturesDate > DateTime.Now select x).ToList<Flight>();
            f.ShowFlight = new Flight();
            f.ShowFlights = fl;
            return View("HomePage", f);
        }
        public ActionResult UserRegister(Users u)
        {
            if (ModelState.IsValid)
            {
                var dal = new Context();
                dal.user.Add(u);
                dal.SaveChanges();
                return View("HomePage", u);
            }
            else
                return View("SignUp",u);
        }
        public ActionResult Registration()
        {
            return View("Registration");
        }
        public ActionResult Login()
        {
            Users u = new Users();
            u.Email = Request.Form["Email"];
            u.Password = Request.Form["Password"];
            var UsersDal = new Context().user;
            foreach (var i in UsersDal)
            {
                if (i.Email.Equals(u.Email) && i.Password.Equals(u.Password)) // user exists
                {
                    
                    return View("HomePage");
                }
            }
            return View("Registration");
        }
        public ActionResult Home()
        {
            return View("Home");
        }
        public ActionResult SearchFlight()
        {
            Context dal = new Context();
            FlightViewModel f = new FlightViewModel();
            string FromValue = Request.Form["txtFrom"].ToString();
            string ToValue = Request.Form["txtTo"].ToString();
            List<Flight> fl = (from x in dal.flights where x.Departures.Contains(FromValue) &&
                               x.Arrivals.Contains(ToValue) select x).ToList<Flight>();
            DateTime FlightDateValue=new DateTime();
            DateTime ArrivalDateValue=new DateTime();
            if (Request.Form["txtFlightDate"].ToString()!=""){ //if not empty
                FlightDateValue = Convert.ToDateTime(Request.Form["txtFlightDate"]);
                List<Flight> l1 = (from x in fl where x.DeparturesDate.CompareTo(FlightDateValue)==0 select x).ToList<Flight>();
                fl = l1;
            }
            if (Request.Form["txtArrivalDate"].ToString() !="")
            {
                ArrivalDateValue = Convert.ToDateTime(Request.Form["txtArrivalDate"]);
                List<Flight> l1 = (from x in fl where x.ArrivalDate.CompareTo(ArrivalDateValue) == 0 select x).ToList<Flight>();
                fl = l1;
            }
            string PriceValue = Request.Form["txtPrice"].ToString();
            if(PriceValue != "") { 
                int price = Int32.Parse(PriceValue);
                List<Flight> l1 = (from x in fl where x.Price<=price select x).ToList<Flight>();
                fl = l1;
            }
            f.ShowFlight = new Flight();
            f.ShowFlights = fl;
            return View("HomePage", f);
        }
        [HttpPost]
        public ActionResult Booking()
        {    
                return View("Booking");
        }
        [HttpPost]
        public ActionResult Purchase(int FlightId,int NumPass) //reduce from seating capacity
        {
            Context dal = new Context();
            Flight f = new Flight();
            foreach (Flight x in dal.flights)
            {
                if (x.FlightID == FlightId)
                {
                    f = x;
                }
            }
            f.SeatingCapacity -= NumPass;
            dal.SaveChanges();
            return View("");
        }
        [HttpPost]
        public ActionResult SearchCreditCard(string FullName, string id)
        {
            Context dal = new Context();
            foreach (CreditCard x in dal.CD)
            {
            if (x.FullName == FullName && x.ID == id)
                {

                    return Json(new { status = "true", card=x.CardNumber });
                }
            }
            return Json(new { status = "false" });
        }
        
        [HttpPost]
        public ActionResult SaveCreditCard(string FullName, string id, string CardNumber, string CardExp, string CVV)
        {
            Context dal = new Context();
            CreditCard f = new CreditCard();
            f.FullName = FullName;
            f.ID = id;
            f.CardNumber = CardNumber;
            f.CardExp = CardExp;
            f.CVV = CVV;
            dal.CD.Add(f);
            dal.SaveChanges();
            return View("Index");
        }
        [HttpPost]
        public ActionResult AddBooking(string BookingID,string FlightID,string NumPassengers)
        {
            Context dal = new Context();
            FlightBooking f = new FlightBooking();
            f.BookingId = BookingID;
            f.FlightId = FlightID;
            f.NumOfTickets = NumPassengers;
            dal.flightBooking.Add(f);
            dal.SaveChanges();
            return View("Index");
        }
    }
}