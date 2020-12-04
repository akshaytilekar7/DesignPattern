using System;

namespace DelegateEventInDI.Events
{
    public class Event
    {

        private event Action _invertedMember1;
        public event Action InvertedMember1
        {
            add => this._invertedMember1 += value;
            remove => this._invertedMember1 -= value;
        }

        private event Action _invertedMember2;
        public event Action InvertedMember2
        {
            add => this._invertedMember2 += value;
            remove => this._invertedMember2 -= value;
        }

        public void MyMethod()
        {
            _invertedMember1?.Invoke();
            _invertedMember2?.Invoke();
        }

    }
}
