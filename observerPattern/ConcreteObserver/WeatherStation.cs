using observerPattern.Interface;
using System;
using System.Collections.Generic;

namespace observerPattern.ConcreteObserver
{
    public class WeatherStation : IObservable
    {
        public WeatherStation()
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
                item.Update();
        }

        public string GetWeatherDataOnWeatherChange()
        {
            Random rnd = new Random();
            return rnd.Next(-20, 45).ToString();
        }

    }


}
