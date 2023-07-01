using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationCashDesk.Models
{
    public class TicketData
    {
        public string? Number { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; } 
        public decimal Seats { get; set; }
        public decimal Price { get; set; }
        public string? Nickname { get; set; }

        public TicketData(string? number, string? name, string? surname, decimal seats, decimal price, string? nickname)
        {
            Number = number;
            Name = name;
            Surname = surname;
            Seats = seats;
            Price = price;
            Nickname = nickname;
        }
    }
}
