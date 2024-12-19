using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Strategy
{
    public class Context
    {
        public ISendingStrategy SendingStrategy { get; set; }


        public void send(ISendingStrategy sendingStrategy = default)
        {
            var strategy = sendingStrategy ?? SendingStrategy;
            if(strategy == null) return;
            strategy.Send();
        }

    }
}
