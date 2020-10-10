using System;
using zAbstractFactoryPattern.ConcreteFactory;
using zAbstractFactoryPattern.Models;

namespace zAbstractFactoryPattern
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

            factory.GetProducts(enums.NOKIA);

            Console.Read();
        }
    }
}
