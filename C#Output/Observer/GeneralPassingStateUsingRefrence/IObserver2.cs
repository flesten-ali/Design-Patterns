using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Observer.GeneralPassingStateUsingRefrence
{
    public abstract class IObserver2
    {
        public abstract void Update();
        public SubjectNorifier2 Subject { get; set; }
    }
}
