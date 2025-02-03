using System;
using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.ConcreteFactory;
using AbstractFactoryPattern.Models;

namespace AbstractFactoryPattern;

class Program
{

    static void Main(string[] args)
    {
        PhoneMakerFactory factory = new PhoneMakerFactory();
        IMobileFactory htc = factory.GetProducts(enums.HTC);

        htc.GetAndroid();
        htc.GetIPhone();

        var samsung = new SamsungFactory();
        samsung.GetAndroid();
        samsung.GetIPhone();

        Console.Read();
    }
}
