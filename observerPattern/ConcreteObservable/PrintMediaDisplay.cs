using observerPattern.ConcreteObserver;
using observerPattern.Interface;
using System;

namespace observerPattern.ConcreteObservable
{
    public class PrintMediaDisplay : IObserver ////subscriber
    {
        private readonly WeatherStation _weatherStation;
        public PrintMediaDisplay(WeatherStation weatherStation)
        {
            _weatherStation = weatherStation;
        }

        public void Update()
        {
            // I guess bad practice as it _ws can access all method used below para upate
            var temp = _weatherStation.GetWeatherDataOnWeatherChange();
            var str = "indian express!! \n weather today :" + DateTime.UtcNow + " is " + temp;
            Console.WriteLine(str);
        }

        public void Update(string message)
        {
            var str = "Breaking news!!! \n weather today :" + DateTime.UtcNow + " is " + message;
            Console.WriteLine(str);
        }
    }
}
