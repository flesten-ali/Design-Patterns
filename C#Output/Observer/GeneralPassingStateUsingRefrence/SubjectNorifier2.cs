using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Observer.GeneralPassingStateUsingRefrence
{
    public abstract class SubjectNorifier2
    {
       private List<IObserver2> _observers = new List<IObserver2>();

        public abstract string State { get; set; }
        public void AddObserver(IObserver2 observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IObserver2 observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
