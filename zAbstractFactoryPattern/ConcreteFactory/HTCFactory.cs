using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.Models;

namespace AbstractFactoryPattern.ConcreteFactory
{
    class HTCFactory : IMobileFactory
    {
        public ISmart GetAndroid()
        {
            return new Titan();
        }

        public INormal GetIPhone()
        {
            return new Genie();
        }
    }
}
