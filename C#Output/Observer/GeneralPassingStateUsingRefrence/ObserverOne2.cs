using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Observer.GeneralPassingStateUsingRefrence
{
    public class ObserverOne2 : IObserver2
    {
        public SubjectNorifier2 Subject { get; set; }

        public ObserverOne2(SubjectNorifier2 subjectNorifier)
        {
            Subject = subjectNorifier;
            Subject.AddObserver(this);
        }

        public override void Update()
        {
            Console.WriteLine("Observer One State is Updated!");
        }
        public void ChangeSubjectState()
        {
            Subject.State = "Changed From One";
        }
    }
}
