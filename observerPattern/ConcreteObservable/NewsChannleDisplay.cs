using observerPattern.ConcreteObserver;
using observerPattern.Interface;
using System;

namespace observerPattern.ConcreteObservable
{
    public class NewsChannelDisplay : IObserver
    {
        private readonly WeatherStation _weatherStation;
        public NewsChannelDisplay(WeatherStation weatherStation)
        {
            this._weatherStation = weatherStation;
        }

        public void Update()
        {
            var temp = _weatherStation.GetWeatherDataOnWeatherChange();
            var str = "Breaking news!!! \n weather today :" + DateTime.UtcNow + " is " + temp;
            Console.WriteLine(str);
        }
    }


}
