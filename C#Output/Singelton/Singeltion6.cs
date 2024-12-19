using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Singelton
{
    public class Singeltion6
    {

        private static readonly Lazy<Singeltion6> _lazy = new Lazy<Singeltion6>(() => new Singeltion6());

        public Singeltion6 Instance
        {
            get
            {
                return _lazy.Value;
            }
        }
    }
}
