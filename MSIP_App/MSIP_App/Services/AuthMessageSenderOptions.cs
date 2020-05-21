using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSIP_App.Services
{
    public class AuthMessageSenderOptions
    {
        public string SendGridUser { get; set; }
        public string SendGridKey { get; set; }

        public AuthMessageSenderOptions()
        {
            SendGridUser = "chaze.stoner@outlook.com";
            SendGridKey = Environment.GetEnvironmentVariable("SendGrid_Email_Key");
        }
    }
}
