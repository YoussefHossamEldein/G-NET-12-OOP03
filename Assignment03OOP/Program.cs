using System.Text;

namespace Assignment03OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            #region Question01
            //a) Has-A-composition
            //b) Dependency
            //c) Inheritance (IS - A)
            //d) HAS-A-Aggregation
            //e) Dependency
            #endregion

            #region Question02

            /* a) yes because the derived class inherits it but it will be also accessible within this 
              derived class only no object or intances from these classes can use it */
            /* b) private protected is accessible within the same class but protected internal within 
             * the same assembly */
            /* C) the sealed class can not be inherited , the sealed method can not be overriden */
            /* D) Yes , i can not just make an object from static classes */

            #endregion

            #region Question03
            Cinema c = new Cinema("Vox Cinema");
            StandardTicket ticket01 = new StandardTicket("A1","Inception",20);
            VIPTicket ticket02 = new VIPTicket(true, "Avengers", 50);
            IMAXTicket ticket03 = new IMAXTicket("Dune", 250, true);

            c.OpenCinema();
            c.AddTicket(ticket01);
            c.AddTicket(ticket02);
            c.AddTicket(ticket03);
            c.PrintAllTickets();
            c.CloseCinema();

            #endregion
        }
    }
}
