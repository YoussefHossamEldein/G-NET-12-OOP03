using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal class Ticket
    {
        private string _moviename;
        private decimal _price;
        private static   int TicketId;
        public decimal Price { get
            {
                return _price;
            }
            set
            {
                 if(value > 0)
                {
                    _price = value;
                }
            }
        }
        public string  MovieName { get
            {
                return _moviename;
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value) || value.Length < 2)
                {
                    Console.WriteLine("Invalid can not be null or less than 2 ");
                }
                _moviename = value;
            }
        }
        public decimal PriceAfterTax => Price *= (14 / 100);
        public Ticket(string moviename,decimal price)
        {
            MovieName = moviename;
            Price = price;
            TicketId++;
        }
        public static int GetTotalTickets() => TicketId;
        public override string ToString()
        {
            return $"Ticket Id: {TicketId} |  Movie Name : {MovieName} | Price : {Price} | Price After Tax : {PriceAfterTax}"; ;
        }


    }
}
