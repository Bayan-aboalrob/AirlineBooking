using AirlineBooking.FlightManagement;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirlineBooking.BookingManagement
{
    public class FlightSearchCriteria
    {
        public decimal? MaxPrice { get; set; }
        public string? DepartureCountry { get; set; }
        public string? DestinationCountry { get; set; }
        public DateTime? DepartureDate { get; set; }
        public string? DepartureAirport { get; set; }
        public string? ArrivalAirport { get; set; }
        public string? Class { get; set; }
    }

}