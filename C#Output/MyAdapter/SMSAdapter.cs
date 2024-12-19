using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.MyAdapter
{
    public class SMSAdapter : IContactAdapter
    {

        private readonly SMSMsgService _smsMsgService;
        private long _number;
        public SMSAdapter (SMSMsgService smsMsgService, long number) {

             _smsMsgService = smsMsgService;
            _number = number;
        }

        public void Contact()
        {
            Console.WriteLine("Some Work");
            _smsMsgService.SendSMS(_number);
            Console.WriteLine("End Work");
        }
    }
}
