using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Observer.GeneralPassingStateUsingRefrence
{
    public class Observable2 : SubjectNorifier2
    {

        private string _state;
        public override string State {

            get
            {
                return _state;
            }
            set
            {
                _state = value;
                NotifyObservers();
            }
        }

        
    }
}
