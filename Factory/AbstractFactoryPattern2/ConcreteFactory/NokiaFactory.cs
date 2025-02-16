using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.Models;

namespace AbstractFactoryPattern.ConcreteFactory
{
    class NokiaFactory : IMobileFactory
    {
        public ISmart GetAndroid()
        {
            return new Lumia();
        }

        public INormal GetIPhone()
        {
            return new Asha();
        }
    }
}
