using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Observer.TicketManagmentSys
{
    public class TicketSeller:ITicketObserver
    {
        public void update(TicketBooked ticketBooked)
        {
            Console.WriteLine($"Ticket Seller updated with {ticketBooked.Id} {ticketBooked.Name}");
        }
    }
}
