using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Singelton
{
    public sealed class Singelton1
    {
        private static Singelton1 _instance;

        private Singelton1() { }

        public static Singelton1 Instance
        {
            get
            {
                return _instance ??= new Singelton1();
            }
        }
    }
}
