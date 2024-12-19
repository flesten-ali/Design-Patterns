using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.MyAdapter
{
    public class EmailService
    {
        public void SendEmail(string email)
        {
            Console.WriteLine($"Email sent to {email}");
        }
    }
}
