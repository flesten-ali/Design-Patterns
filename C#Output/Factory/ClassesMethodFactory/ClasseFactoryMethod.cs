using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Output.Classes;

namespace C_Output.Factory.ClassesFactory
{
    public abstract class ClasseFactoryMethod
    {
        public abstract IClass CreateClass();

        public IClass GetClass()
        {
            var classObj = CreateClass();
            return classObj;
        }

    }

}
