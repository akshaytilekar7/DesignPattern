using zAbstractFactoryPattern.AbstractFactory;
using zAbstractFactoryPattern.Models;

namespace zAbstractFactoryPattern.ConcreteFactory
{
    class SamsungFactory : IPhoneFactory
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
}
