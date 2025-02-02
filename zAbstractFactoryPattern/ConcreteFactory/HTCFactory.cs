using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.Models;

namespace AbstractFactoryPattern.ConcreteFactory
{
    class HTCFactory : IMobileFactory
    {
        public ISmart GetSmart()
        {
            return new Titan();
        }

        public INormal GetNormal()
        {
            return new Genie();
        }
    }
}
