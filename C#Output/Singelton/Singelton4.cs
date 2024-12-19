using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Singelton
{
    public sealed class Singelton4
    {
        private static readonly Singelton4 _instance = new Singelton4();
        public static readonly string Name = "Singelton";//

        static Singelton4() { }

        public static Singelton4 Instance
        {
            get
            {
                return _instance;
            }
        }




    }
}
