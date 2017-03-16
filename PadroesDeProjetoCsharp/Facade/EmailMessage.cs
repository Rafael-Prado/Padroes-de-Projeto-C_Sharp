using System;

namespace Facade
{
    public class EmailMessage
    {
        public string Message { get; set; }
        private EmailFormat _mailFormat;

        public EmailMessage(string message, EmailFormat format)
        {
            //format mesagem aqui..
            Message = message;
            _mailFormat = format;
        }


    }
}
