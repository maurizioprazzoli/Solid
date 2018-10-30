using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.Refactoring
{
    public class SMS : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendMessage()
        {
            //Send sms
        }
    }
}
