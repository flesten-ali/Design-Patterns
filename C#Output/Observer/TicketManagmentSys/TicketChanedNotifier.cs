using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Observer.TicketManagmentSys
{
    public class TicketChanedNotifier
    {
        private List<ITicketObserver> _ticketObservers = new List<ITicketObserver>();

        public void AddTicketServiceObserver(ITicketObserver ticketObserver)
        {
            _ticketObservers.Add(ticketObserver);
        }

        public void RemoveTicketServiceObserver(ITicketObserver ticketObserver)
        {
            _ticketObservers.Remove(ticketObserver);
        }

        public void Notify(TicketBooked ticketBooked)
        {
            foreach (var ticketObserver in _ticketObservers)
            {
                ticketObserver.update(ticketBooked);
            }
        }
    }
}
