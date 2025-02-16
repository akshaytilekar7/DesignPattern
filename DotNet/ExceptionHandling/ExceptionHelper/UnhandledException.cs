using System;

namespace ExceptionHandling.ExceptionHelper
{
    public class UnhandledException : Exception
    {
        private string _stackTrace;
        private string _source;

        public UnhandledException(string message, string stackTrace, string source, Exception innerException) : base(message, innerException)
        {
            _stackTrace = stackTrace;
            _source = source;
        }

        public override string StackTrace
        {
            get { return _stackTrace; }
        }

        public override string Source
        {
            get { return _source; }
        }
    }
}