using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Observer.TicketManagmentSys
{
    public interface ITicketObserver
    {
        void update(TicketBooked ticketBooked);
    }
}
