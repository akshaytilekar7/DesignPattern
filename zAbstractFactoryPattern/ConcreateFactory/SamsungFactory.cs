using AbstractFactoryDemo.Models;

namespace AbstractFactoryDemo
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
