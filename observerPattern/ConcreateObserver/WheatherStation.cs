using observerPattern.Interface;
using System;
using System.Collections.Generic;

namespace observerPattern.ConcreateObserver
{
    public class WheatherStation : IObservable
    {
        public WheatherStation()
        {
            SubscriberList = new List<IObserver>();
        }
        public List<IObserver> SubscriberList { get; set; }

        public void Add(IObserver subscriber)
        {
            if (SubscriberList.Contains(subscriber))
                return;

            SubscriberList.Add(subscriber);
        }

        public void Remove(IObserver subscriber)
        {
            SubscriberList.Remove(subscriber);
        }

        public void Notify()
        {
            foreach (IObserver item in SubscriberList)
                item.update();
        }

        public string GetWeather()
        {
            Random rnd = new Random();
            return rnd.Next(-20, 45).ToString();
        }

    }


}
