namespace SingletonThreadSafe;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Singleton1 singleton1 = Singleton1.Instance;
        singleton1.GetCountries();

        Singleton1 anotherSingleton1 = Singleton1.Instance;
        anotherSingleton1.GetCountries();

        Console.WriteLine($"Are both instances the same? {singleton1 == anotherSingleton1}");


        Singleton2 singleton2 = Singleton2.Instance;
        singleton2.GetCountries();

        Singleton2 anotherSingleton2 = Singleton2.Instance;
        anotherSingleton2.GetCountries();

        Console.WriteLine($"Are both instances the same? {singleton2 == anotherSingleton2}");
    }
}

