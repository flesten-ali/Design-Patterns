using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Strategy
{
    internal class SMSSender : ISendingStrategy
    {
        public void Send()
        {
            Console.WriteLine("This Strategy is For sending SMS");
        }
    }
}
