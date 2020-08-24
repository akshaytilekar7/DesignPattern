using AbstractFactoryDemo.Models;

namespace AbstractFactoryDemo
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
