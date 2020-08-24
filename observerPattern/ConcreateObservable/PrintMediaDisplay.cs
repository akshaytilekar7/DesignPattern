using observerPattern.ConcreateObserver;
using observerPattern.Interface;
using System;

namespace observerPattern.ConcreateObservable
{
    public class PrintMediaDisplay : IObserver
    {
        private readonly WheatherStation wheatherStation;
        public PrintMediaDisplay(WheatherStation wheatherStation)
        {
            this.wheatherStation = wheatherStation;
        }

        public void update()
        {
            var temp = wheatherStation.GetWeather();
            var str = "indian express!! \n weather today :" + DateTime.UtcNow + " is " + temp;
            Console.WriteLine(str);
        }
    }
}
