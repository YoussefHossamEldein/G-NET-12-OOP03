using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(string seatnumber,string moviename,decimal price) : base(moviename, price)
        {
            SeatNumber = seatnumber;
        }
        public override string ToString()
        {
            return $"Seat Number : {SeatNumber}";
        }
    }
}
