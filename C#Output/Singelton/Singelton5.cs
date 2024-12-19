using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Singelton
{
    public class Singelton5
    {

        public static readonly string Name = "Singelton";//

        private Singelton5() { }

        public static Singelton5 Instance
        {
            get
            {
                return SingeltonHolder._instance;
            }
        }

        private class SingeltonHolder
        {
            internal static readonly Singelton5 _instance = new Singelton5();

            static SingeltonHolder() { }

        }
    }
}
