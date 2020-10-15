using System;
using System.Threading;

namespace PublisherSubscriber.Publisher
{
    public class Clock // PUBLISHER
    {
        private int _second;

        public delegate void SecondChangeHandler(string str);
        public event SecondChangeHandler SecondChange;
        private void Notify(string str)
        {
            SecondChange?.Invoke(str);
        }

        public void GetUpdatedTimeOnSecondChange()
        {
            for (; ; )
            {
                Thread.Sleep(2000);

                DateTime dbDateTime = DateTime.Now; // get data from Database

                if (dbDateTime.Second != _second)
                {
                    // u can use any one np
                    Notify(dbDateTime.ToLongTimeString());
                    SecondChange?.Invoke(dbDateTime.ToLongTimeString());
                }

                _second = dbDateTime.Second;
            }
        }
    }
}
