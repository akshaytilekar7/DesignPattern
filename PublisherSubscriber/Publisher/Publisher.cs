namespace PublisherSubscriber.Publisher
{
    public class Clock
    {
        public delegate void SecondChangeHandler(string str);
        public event SecondChangeHandler SecondChange;
        public void Notify(string str)
        {
            SecondChange?.Invoke(str);
        }
    }
}
