
namespace Facade
{
    public class FacadeEmail
    {
        private Email _email;
        private EmailFormat _emailFormat;
        private SmtpSettings _conf;
        private EmailMessage _msg;

        public FacadeEmail()
        {
            _email = new Email(_conf);
            _emailFormat = new EmailFormatTxt();
            _msg = new EmailMessage( "", _emailFormat );
            _conf = new SmtpSettings()
            {
                ServerName = "smt.gmail.com",
                Password = "123",
                UserName = "default"
            };
        }
        public void Enviar(string messagem)
        {
            _msg.Message = messagem;
            _email.Send(_msg);
        }
    }
}
