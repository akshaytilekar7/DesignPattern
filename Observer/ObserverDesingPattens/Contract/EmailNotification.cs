namespace ObserverDesignPattens.Contract;

public class EmailNotification : INotificationSubscriber
{
    public void Update(string message)
    {
        Console.WriteLine($"Email Notification: {message}");
        // Simulate sending an email
    }
}
