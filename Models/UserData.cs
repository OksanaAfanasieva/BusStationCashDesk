using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationCashDesk.Windows_Forms
{
    public class UserData
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
        public bool IsAdmin { get; set; }

        public UserData(string? name, string? password, bool isAdmin)
        {
            Name = name;
            Password = password;
            IsAdmin = isAdmin;
        }
    }
}
