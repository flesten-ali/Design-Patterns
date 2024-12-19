using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Strategy
{
    internal class EmailSender : ISendingStrategy
    {
        public void Send()
        {
            Console.WriteLine("This Strategy is For Sending Email");
        }
    }
}
