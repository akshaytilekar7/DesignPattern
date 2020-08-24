using System;

namespace AbstractFactoryDemo
{
    class PhoneMakerFactory
    {
        public IPhoneFactory GetProducts(enums productName)
        {
            switch (productName)
            {
                case enums.SAMSUNG:
                    return new SamsungFactory();
                case enums.HTC:
                    return new HTCFactory();
                case enums.NOKIA:
                    return new NokiaFactory();
            }

            throw new Exception("invalid input");
        }
    }
}
