namespace ObserverDesignPattens.Contract;

public interface INotificationSubscriber
{
    void Update(string message);
}
