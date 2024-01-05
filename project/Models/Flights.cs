using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace project.Models
{
    public class Flight
    {
        [Key]
        public int FlightID { get; set; }

        [Required(ErrorMessage = "Required Flight company name")]
        [Display(Name = "Flight company name")]
        [MinLength(2, ErrorMessage = "Minimun 2 char required"), MaxLength(20, ErrorMessage = "Maximun 20 char allowed")]
        public string FlightCompanyName { get; set; }

        [Required(ErrorMessage = "Required Seating Capacity")]
        [Display(Name = "Seating capacity number")]
        public int SeatingCapacity { get; set; }

        [Required(ErrorMessage = "Required Departure city")]
        [Display(Name = "Departure from")]
        [StringLength(40, ErrorMessage = "Maximun 40 char allowed")]
        public string Departures { get; set; }

        [Required(ErrorMessage = "Required Arrival city")]
        [Display(Name = "Arrivals to")]
        [StringLength(40, ErrorMessage = "Maximun 40 char allowed")]
        public string Arrivals { get; set; }


        //[Required(ErrorMessage = "Required Departures Date")]
        [Display(Name = "Departures Date")]
        [DataType(DataType.Date)]
        public DateTime DeparturesDate { get; set; }

        [Display(Name = "Departures Time")]
        [StringLength(15)]
        public string DeparturesTime { get; set; }

        [Display(Name = "Arrival Date")]
        [DataType(DataType.Date)]
        public DateTime ArrivalDate { get; set; }

        [Display(Name = "Arrival Time")]
        [StringLength(15)]
        public string ArrivalTime { get; set; }

        [Required(ErrorMessage = "Required Price")]
        [Display(Name = "Price")]
        public int Price { get; set; }


    }
    public class FlightBooking
    {
        [Key]
        public string BookingId { get; set; }
        public string FlightId { get; set; }


        public string NumOfTickets { get; set; }
    }
}