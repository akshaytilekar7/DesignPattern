using System.Collections.Generic;

namespace observerPattern.Interface
{
    // publisher
    public interface IObservable
    {
        List<IObserver> SubscriberList { get; set; }

        void Add(IObserver subscriber);

        void Remove(IObserver subscriber);

        void Notify();
    }
}
