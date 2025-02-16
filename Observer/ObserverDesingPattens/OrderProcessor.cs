namespace ObserverDesingPattens;

using ObserverDesingPattens.Contract;
using System;
using System.Collections.Generic;

// Publisher (Subject)
public class OrderProcessor
{
    private readonly List<INotificationSubscriber> _subscribers = new List<INotificationSubscriber>();

    public void Add(INotificationSubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    public void Remove(INotificationSubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    public void Process(string orderId)
    {
        Console.WriteLine($"Processing order {orderId}...");
        Notify($"Order {orderId} has been successfully processed.");
    }

    private void Notify(string message)
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.Update(message);
        }
    }
}
