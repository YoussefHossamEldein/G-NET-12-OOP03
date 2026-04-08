using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal class Cinema
    {
        private Ticket[] _tickets = new Ticket[20];
        private Projector projector = new Projector();
        public string Name { get; set; }
        public Cinema(string name)
        {
            Name = name;
        }
        public void AddTicket(Ticket t)
        {
            for(int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null)
                {
                    _tickets[i] = t;
                }
            }
        }
        public void PrintAllTickets()
        {
            Console.WriteLine("======== All Tickets ========");
            foreach(var ticket in _tickets)
            {
                Console.WriteLine(ticket);
            }
        }
     public void OpenCinema()
        {
            projector.Start();
        }
        public void CloseCinema()
        {
            projector.Stop();
        }
    }
}
