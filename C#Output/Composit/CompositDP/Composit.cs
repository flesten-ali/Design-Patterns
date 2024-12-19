using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Composit.CompositDP
{
    internal class Composit : Component
    {
        List<Component> components = new List<Component>();
        public Composit(string name) : base(name)
        {
        }
        public override void PrimaryOperation()
        {
            Console.WriteLine($"This is composit {Name}");
            foreach (var component in components)
            {
                component.PrimaryOperation();
            }
        }
        public void Add(Component c)
        {
            components.Add(c);
        }
        public void Remove(Component c)
        {
            components.Remove(c);
        }

    }
}
