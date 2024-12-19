using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Output.Classes;

namespace C_Output.Factory.ClassesFactory
{
    public class ClassOneFactory : ClasseFactoryMethod
    {
        public override IClass CreateClass()
        {
            return new Class1();

        }
    }
}
