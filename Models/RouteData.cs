using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationCashDesk.Classes
{
    public class RouteData
    {
        public string? Number { get; set; }
        public string? FromName { get; set; }
        public string? ToName { get; set; }
        public DateTime DateTimeFrom { get; set; }
        public string TimeFrom { get; set; }
        public DateTime DateTimeTo { get; set; }
        public string TimeTo { get; set; }
        public List<string>? Stops { get; set; }
        public List<string>? TimeStop { get; set; }
        public string FreeSeats { get; set; }
        public string Price { get; set; }

        public RouteData(string? number, string? fromName, string? toName, 
            DateTime dateTimeFrom, string timeFrom, DateTime dateTimeTo,
            string timeTo, List<string>? stops, List<string>? timeStop, 
            string freeSeats, string price)
        {
            Number = number;
            FromName = fromName;
            ToName = toName;
            DateTimeFrom = dateTimeFrom;
            TimeFrom = timeFrom;
            DateTimeTo = dateTimeTo;
            TimeTo = timeTo;
            Stops = stops;
            TimeStop = timeStop;
            FreeSeats = freeSeats;
            Price = price;
        }
    }
}
