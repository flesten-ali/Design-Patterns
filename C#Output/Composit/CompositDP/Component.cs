using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Composit.CompositDP
{
    public abstract class Component
    {
        public string Name { get; private set; }
        protected Component(string name)
        {
            Name = name;

        }

        public abstract void PrimaryOperation();
    }
}
