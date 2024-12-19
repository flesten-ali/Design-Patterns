using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Decorator
{
    public class DecoratorTwo : IPerson
    {
        private readonly IPerson _person;
        public DecoratorTwo(IPerson person)
        {
            _person = person;
        }
        public int Id { get  ; set  ; }
        public string Name { get  ; set ; }

        public void GetPerson()
        {
            Console.WriteLine("Start Additional work from Decorator two");
            _person.GetPerson();
            Console.WriteLine("End Additional work from Decorator two");
        }
    }
}
