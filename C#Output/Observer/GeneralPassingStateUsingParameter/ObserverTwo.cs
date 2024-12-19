using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Observer.General
{
    public class ObserverTwo:IObserver
    {
        public void Update(ChanedState state)
        {
            Console.WriteLine("Observer Two is Notified!");
        }
    }
}
