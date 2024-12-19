using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Output.Classes;
using C_Output.Labels;

namespace C_Output.Factory.AbstractFactory
{
    public interface IAbstractFactory
    {
        // Common Theme for many Factories
        public IClass CreateClass();
        public ILabel CreateLabel(string name);
    }
}
