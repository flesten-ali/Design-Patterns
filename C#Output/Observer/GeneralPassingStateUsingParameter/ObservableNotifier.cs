using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Observer.General
{
    public abstract class ObservableNotifier
    {
        private List<IObserver> _observers = new List<IObserver>();


        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer) {

            _observers.Remove(observer);
        }
        public void NotifyObservers(ChanedState state)
        {
            foreach (var observer in _observers)
            {
                observer.Update(state);
            }
        }
    }
}
