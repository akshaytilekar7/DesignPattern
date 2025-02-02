namespace observerPattern.Interface
{

    //subscriber
    public interface IObserver
    {
        void Update();
        void Update(string message);

    }


}
