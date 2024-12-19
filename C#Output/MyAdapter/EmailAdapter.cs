using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.MyAdapter
{
    public class EmailAdapter : IContactAdapter
    {

        private EmailService _emailService;
        private string _email;

        public EmailAdapter(EmailService emailService, string email) {
         _emailService = emailService;
         _email = email;
        }
        public void Contact()
        {
            _emailService.SendEmail(_email);
        }
    }
}
