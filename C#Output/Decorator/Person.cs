using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Decorator
{
    public class Person : IPerson
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

        public void GetPerson()
        {
            Console.WriteLine($"Person {Name} with Id = {Id}");
        }


    }
}
