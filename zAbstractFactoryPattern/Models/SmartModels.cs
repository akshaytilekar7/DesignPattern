using zAbstractFactoryPattern.AbstractFactory;

namespace zAbstractFactoryPattern.Models
{
    class Titan : ISmart
    {
        public string Name()
        {
            return "Titan";
        }
    }

    class Lumia : ISmart
    {
        public string Name()
        {
            return "Lumia";
        }
    }

    class GalaxyS2 : ISmart
    {
        public string Name()
        {
            return "GalaxyS2";
        }
    }
}
