using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.Models;

namespace AbstractFactoryPattern.ConcreteFactory;

class SamsungFactory : IMobileFactory
{
    public ISmart GetAndroid()
    {
        return new GalaxyS2();
    }

    public INormal GetIPhone()
    {
        return new Primo();
    }
}
