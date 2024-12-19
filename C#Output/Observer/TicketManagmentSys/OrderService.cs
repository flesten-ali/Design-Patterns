using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Observer.TicketManagmentSys
{
    public class OrderService:TicketChanedNotifier
    {
        public void OrderIsFulfilled(TicketBooked ticketBooked)
        {
            Console.WriteLine("Ticket Booked");
            Notify(ticketBooked);
        }
    }
}
