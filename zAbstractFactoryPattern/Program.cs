using System;

namespace AbstractFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneMakerFactory factory = new PhoneMakerFactory();

            var samsung = factory.GetProducts(enums.SAMSUNG);
            samsung.GetSmart();
            samsung.GetNormal();


            factory.GetProducts(enums.HTC);
            factory.GetProducts(enums.NOKIA);

            Console.Read();
        }
    }
}
