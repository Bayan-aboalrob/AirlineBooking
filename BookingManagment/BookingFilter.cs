﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineBooking.BookingManagment
{
    public class BookingFilter
    {
        public int? FlightId { get; set; }
        public decimal? MaxPrice { get; set; }
        public string? DepartureCountry { get; set; }
        public string? DestinationCountry { get; set; }
        public DateTime? DepartureDate { get; set; }
        
        public string? DepartureAirport { get; set; }
        public string? ArrivalAirport { get; set; }
        public int? PassengerId { get; set; }
        public string? Class { get; set; }
    }

}
