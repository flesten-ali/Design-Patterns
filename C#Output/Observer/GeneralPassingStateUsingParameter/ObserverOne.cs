using C_Output.Observer.GeneralPassingStateUsingRefrence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Observer.General
{
    public class ObserverOne : IObserver
    {

 
        public void Update(ChanedState state)
        {

            Console.WriteLine("Observer One is Notified!");
        }
    }
}
