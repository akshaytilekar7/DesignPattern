using NInjectConsole.Actions.interfaces;
using System;

namespace NInjectConsole.Actions
{
    public class LoggerDbAction : ILogger
    {
        public void Log(string data)
        {
            // log to file
            Console.WriteLine(this.GetType().Name + " " + data);
        }
    }
}
