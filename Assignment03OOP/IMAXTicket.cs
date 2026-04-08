using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }
        public IMAXTicket(string moviename,decimal price,bool is3d) : base(moviename, price)
        {
            Is3D = is3d;
            if(Is3D)
            {
                Price += 30;
            }
        }
        public override string ToString()
        {
            return $"Is3D: {Is3D}";
        }
    }
}
