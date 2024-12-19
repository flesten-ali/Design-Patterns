using C_Output.Classes;
using C_Output.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Factory.AbstractFactory
{
    public class FactoryTwo : IAbstractFactory
    {
        public IClass CreateClass()
        {
            return new Class2();
        }

        public ILabel CreateLabel(string name)
        {
            return new LabelTwo();
        }
    }
}
