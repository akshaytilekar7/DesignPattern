using Ninject;
using NInjectConsole.Actions;
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

            //Scenario 1
            var logger = kernel.Get<ILogger>("DB");
            var uILogger = new UILogger(logger);
            uILogger.LogFromUI("test data");


            //Scenario 2
            logger = kernel.Get<ILogger>("DB"); // in this case still we get DB instance in action class hoiwever we difine "[Named("File")]ILogger logger" in CTOR 

            logger = kernel.Get<ILogger>(); // Error activating ILogger More than one matching bindings
            MailSenderAction mailSenderAction = new MailSenderAction(logger);
            mailSenderAction.Send("David", "new data ");
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
