using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    public class Email
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendEmail()
        {
            //Send email
        }
    }
}
