using zAbstractFactoryPattern.AbstractFactory;
using zAbstractFactoryPattern.Models;

namespace zAbstractFactoryPattern.ConcreteFactory
{
    class HTCFactory : IPhoneFactory
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
