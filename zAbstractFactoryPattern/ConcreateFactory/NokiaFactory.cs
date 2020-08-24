using AbstractFactoryDemo.Models;

namespace AbstractFactoryDemo
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
