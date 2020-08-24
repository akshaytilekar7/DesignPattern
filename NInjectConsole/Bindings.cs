using Ninject.Modules;
using NInjectConsole.Actions;
using NInjectConsole.Actions.interfaces;

namespace NInjectConsole
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IMailSender>().To<MailSenderAction>();
            Bind<ILogger>().To<LoggerDbAction>().Named("DB");
            Bind<ILogger>().To<LoggerFileAction>().Named("File");

        }
    }
}
