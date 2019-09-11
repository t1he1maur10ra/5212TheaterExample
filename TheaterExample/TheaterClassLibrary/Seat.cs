using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterClassLibrary
{
    public class Seat
    {
        /*Basic required properties, add more in if you need*/
        public bool Booked { get; set; } = false;
        public string AdultOrChild { get; set; }

        /*Constructor*/
        public Seat(bool booked, string adultOrChild)
        {
            Booked = booked;
            AdultOrChild = adultOrChild;
        }
    }
}
