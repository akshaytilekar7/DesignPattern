using System;
using AbstractFactoryPattern.ConcreteFactory;
using AbstractFactoryPattern.Models;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneMakerFactory factory = new PhoneMakerFactory();

            var samsung = new SamsungFactory();
            samsung.GetSmart();
            samsung.GetNormal();

            var htc = factory.GetProducts(enums.HTC);
            htc.GetSmart();
            htc.GetNormal();


            Console.Read();
        }
    }
}
