using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using AirlineBooking.BookingManagement;
using AirlineBooking.FlightManagement;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace AirlineBooking.CSVImporter
{
    public class CsvImporter
    {
        private string _filePath;

        public CsvImporter(string filePath)
        {
            _filePath = filePath;
        }

        public List<Booking> ReadBookingsFromCsv()
        {
            var bookings = new List<Booking>();
            try
            {
                using (var reader = new StreamReader(_filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    bookings = csv.GetRecords<Booking>().ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the CSV file: {ex.Message}");
            }
            return bookings;
        }

        public List<Flight> ReadFlightsFromCsv()
        {
            var flights = new List<Flight>();
            try
            {
                using (var reader = new StreamReader(_filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    flights = csv.GetRecords<Flight>().ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the CSV file: {ex.Message}");
            }
            return flights;
        }
    }
}
