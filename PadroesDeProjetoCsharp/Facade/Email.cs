


using System;

namespace Facade
{
    public class Email
    {
        private SmtpSettings _conf;

        public Email(SmtpSettings conf)
        {
            this._conf = conf;
        }
        public void Send(EmailMessage message)
        {
            //Usando Configurações SMTP
            Console.WriteLine("Enviando Mesagem....");
            Console.WriteLine(message.Message);

        }
    }
}
