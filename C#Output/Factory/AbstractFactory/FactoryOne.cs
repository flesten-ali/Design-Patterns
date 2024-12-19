using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Output.Classes;
using C_Output.Labels;

namespace C_Output.Factory.AbstractFactory
{
    public class FactoryOne : IAbstractFactory
    {
        public IClass CreateClass()
        {
            return new Class1();
        }

        public ILabel CreateLabel(string name)
        {
            return new LabelOne();
        }
    }
}
