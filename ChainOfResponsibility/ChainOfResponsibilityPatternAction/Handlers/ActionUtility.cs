using ChainOfResponsibilityPatternAction.ExceptionsHelper;
using System;

namespace ChainOfResponsibilityPatternAction.Handlers
{
    public class ActionUtility<T>
    {
        public T Type { get; set; }
        public Func<T, bool> Func { get; set; }
        public FaultCodes FaultCodes { get; set; }

    }
}