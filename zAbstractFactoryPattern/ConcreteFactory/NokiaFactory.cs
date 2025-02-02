using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.Models;

namespace AbstractFactoryPattern.ConcreteFactory
{
    class NokiaFactory : IMobileFactory
    {
        public ISmart GetSmart()
        {
            return new Lumia();
        }

        public INormal GetNormal()
        {
            return new Asha();
        }
    }
}
