using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Observer.GeneralPassingStateUsingRefrence
{
    public class ObserverTwo2 : IObserver2
    {
        public ObserverTwo2(SubjectNorifier2 subjectNorifier)
        {
            Subject = subjectNorifier;
            Subject.AddObserver(this);
        }

        public override void Update()
        {
            Console.WriteLine("Observer Two State is Changed");
        }
        public void ChangeSubjectState()
        {
            Subject.State = "Changed From Two";

        }
    }
}
