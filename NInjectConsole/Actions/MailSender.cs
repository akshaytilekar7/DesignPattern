using Ninject;
using NInjectConsole.Actions.interfaces;
using System;

namespace NInjectConsole.Actions
{
    public class MailSenderAction : IMailSender
    {
        private readonly ILogger _logger;

        public MailSenderAction([Named("File")]ILogger logger)
        {
            _logger = logger;
        }
        public void Send(string name, string data)
        {
            // send email
            Console.WriteLine("sent email to :" + name);

            //send log
            _logger.Log(data);

        }
    }
}
