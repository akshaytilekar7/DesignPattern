using Ninject;
using NInjectConsole.Actions.interfaces;
using System;
using System.Reflection;

namespace NInjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var mailSender = kernel.Get<IMailSender>();
            var uIMailSender = new UIMailSender(mailSender);
            uIMailSender.SendEmailFromUI("test@test.com");

            var logger = kernel.Get<ILogger>("DB");
            var uILogger = new UILogger(logger);
            uILogger.LogFromUI("test data");

            Console.ReadLine();
        }
    }
}

// one interface can bind to multiple instance, 
//      Bind<ILogger>().To<LoggerDbAction>().Named("DB");
//      Bind<ILogger>().To<LoggerFileAction>().Named("File");

// When user
//  scenario 1 direct
//      var logger = kernel.Get<ILogger>("DB");
//      var uILogger = new UILogger(logger);

// scenario 2 indirect (give name in CTOR definition)
// public MailSenderAction([Named("File")]ILogger logger)
