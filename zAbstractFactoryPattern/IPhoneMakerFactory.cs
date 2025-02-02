using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.Models;

namespace AbstractFactoryPattern;

internal interface IPhoneMakerFactory
{
    IMobileFactory GetProducts(enums productName);
}