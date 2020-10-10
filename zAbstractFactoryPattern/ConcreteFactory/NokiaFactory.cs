using zAbstractFactoryPattern.AbstractFactory;
using zAbstractFactoryPattern.Models;

namespace zAbstractFactoryPattern.ConcreteFactory
{
    class NokiaFactory : IPhoneFactory
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
