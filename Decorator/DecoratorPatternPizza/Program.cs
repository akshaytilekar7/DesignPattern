using DecoratorPatternPizza.Component;
using DecoratorPatternPizza.ConcreteComponents;
using DecoratorPatternPizza.ConcreteDecorators;
using System;

namespace DecoratorPatternPizza
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizzaService p = new Ham(new Cheese(new LargePizza())); // L


            Console.WriteLine(p.GetDescription());
            Console.WriteLine(p.CalculateCost());
            Console.ReadKey();
        }
    }
}
