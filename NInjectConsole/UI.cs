using NInjectConsole.Actions.interfaces;

namespace NInjectConsole
{
    public class UIMailSender
    {
        private readonly IMailSender _mailSender;

        public UIMailSender(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }
        public void SendEmailFromUI(string toAddress)
        {
            //WITHOUT N INJECT
            //IMailSender mailSender = new MailSenderAction();
            //mailSender.Send(toAddress, "This is without N inject example");

            _mailSender.Send(toAddress, "N inject example");
        }

    }

    public class UILogger
    {
        private readonly ILogger _logger;

        public UILogger(ILogger logger)
        {
            _logger = logger;
        }
        public void LogFromUI(string data)
        {
            _logger.Log(data);
        }

    }
}
