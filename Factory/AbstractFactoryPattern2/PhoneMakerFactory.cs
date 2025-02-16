using System;
using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.ConcreteFactory;
using AbstractFactoryPattern.Models;

namespace AbstractFactoryPattern;

class PhoneMakerFactory : IPhoneMakerFactory
{
    public IMobileFactory GetProducts(enums productName)
    {
        switch (productName)
        {
            case enums.SAMSUNG:
                return new SamsungFactory();
            case enums.HTC:
                return new HTCFactory();
            case enums.NOKIA:
                return new NokiaFactory();
        }

        throw new Exception("invalid input");
    }
}
