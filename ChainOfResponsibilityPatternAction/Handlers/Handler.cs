using ChainOfResponsibilityPatternAction.ExceptionsHelper;
using System;
using System.Collections.Generic;

namespace ChainOfResponsibilityPatternAction.Handlers
{
    public class Handler<T> where T : class, new()
    {
        public Handler(T type)
        {
            _type = type;
        }

        private readonly T _type;

        private readonly List<ActionUtility<T>> _actionUtility = new List<ActionUtility<T>>();
        public Handler<T> AddNext(Func<T, bool> condition, FaultCodes faultCodes)
        {
            var actionUtility = new ActionUtility<T>()
            {
                Type = _type,
                Func = condition,
                FaultCodes = faultCodes
            };

            _actionUtility.Add(actionUtility);
            return this;
        }

        public Handler<T> Execute()
        {
            foreach (var actionUtility in _actionUtility)
            {
                var isValid = actionUtility.Func(actionUtility.Type);
                if (!isValid)
                    throw new Exception(actionUtility.FaultCodes.ToString());
            }
            return this;
        }
    }
}
