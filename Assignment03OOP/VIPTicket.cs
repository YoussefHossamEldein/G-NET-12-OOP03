using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal class VIPTicket : Ticket
    {
        public bool  LoungeAccess { get; set; }
        public decimal ServiceFee { get; } = 50;
        public VIPTicket(bool loungeaccess,string moviename,decimal price) : base(moviename, price)
        {
            LoungeAccess = loungeaccess;
           
        }
        public override string ToString()
        {
            return $"Lounge Access: {LoungeAccess} | Service Fees : {ServiceFee}";
        }
    }
}
