using ExceptionHandling.ExceptionHelper.Enums;
using System;

namespace ExceptionHandling.ExceptionHelper
{
    public class BusinessException : Exception
    {
        private string _stackTrace;
        private string _source;

        public ErrorCodes ErrorCode;

        public ErrorTypes ErrorType;

        public BusinessException(string message, string stackTrace, string source, ErrorCodes errorCode, ErrorTypes errorType, Exception innerException) : base(message, innerException)
        {
            _stackTrace = stackTrace;
            _source = source;
            ErrorCode = errorCode;
            ErrorType = errorType;
        }

        public BusinessException(ErrorTypes errorType, ErrorCodes errorCode)
        {
            ErrorType = errorType;
            ErrorCode = errorCode;
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