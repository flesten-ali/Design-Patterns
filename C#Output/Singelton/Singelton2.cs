using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Singelton
{
    public sealed class Singelton2
    {
        private static Singelton2 _instance;
        private static object _instanceLock = new object();

        private Singelton2() { }

        public static Singelton2 Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    return _instance ??= new Singelton2();
                }
            }
        }
    }
}
