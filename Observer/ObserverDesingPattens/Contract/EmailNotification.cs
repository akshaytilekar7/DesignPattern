using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesingPattens.Contract;

public class EmailNotification : INotificationSubscriber
{
    public void Update(string message)
    {
        Console.WriteLine($"Email Notification: {message}");
        // Simulate sending an email
    }
}
