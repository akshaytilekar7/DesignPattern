﻿using observerPattern.Interface;
using System;
using System.Collections.Generic;

namespace observerPattern.ConcreteObserver
{
    public class WeatherStation : IObservable
    {
        public List<IObserver> SubscriberList { get; set; } = new List<IObserver>();

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

            // OR

            foreach (IObserver item in SubscriberList)
                item.Update(GetWeatherDataOnWeatherChange());
        }

        public string GetWeatherDataOnWeatherChange()
        {
            Random rnd = new Random();
            return rnd.Next(-20, 45).ToString();
        }

    }


}
