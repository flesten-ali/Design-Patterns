using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Singelton
{
    public sealed class Singelton3
    {
        private static Singelton3 _instance;
        private static object _instanceLock = new object();

        private Singelton3() { }

        public static Singelton3 Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        if (_instance == null)
                            return _instance ??= new Singelton3();
                    }
                }
                return _instance;
            }
        }
    }
}
