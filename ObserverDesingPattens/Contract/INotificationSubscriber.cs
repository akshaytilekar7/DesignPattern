namespace ObserverDesingPattens.Contract;

public interface INotificationSubscriber
{
    void Update(string message);
}
