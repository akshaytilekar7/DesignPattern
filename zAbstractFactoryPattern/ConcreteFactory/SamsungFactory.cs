using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.Models;

namespace AbstractFactoryPattern.ConcreteFactory;

class SamsungFactory : IMobileFactory
{
    public ISmart GetSmart()
    {
        return new GalaxyS2();
    }

    public INormal GetNormal()
    {
        return new Primo();
    }
}
