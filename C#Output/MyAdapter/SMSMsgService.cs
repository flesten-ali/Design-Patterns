using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.MyAdapter
{
    public class SMSMsgService
    {
        public void SendSMS(long num)
        {
            Console.WriteLine($"SMS Sent to {num}");
        }
    }
}
