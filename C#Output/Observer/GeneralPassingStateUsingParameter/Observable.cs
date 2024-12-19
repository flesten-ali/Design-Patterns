using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Observer.General
{
    public class Observable:ObservableNotifier
    {
        public void ChangeStateOfObservable(ChanedState state)
        {
            Console.WriteLine("Subject State is Changed!!!");
            NotifyObservers(state);
        }

    }
}
