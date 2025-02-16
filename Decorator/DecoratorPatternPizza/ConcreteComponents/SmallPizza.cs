using DecoratorPatternPizza.Component;

namespace DecoratorPatternPizza.ConcreteComponents
{
    public class SmallPizza : IPizzaService
    {
        public string GetDescription()
        {

            return $"{this.GetType().Name}"; //SMALL
        }

        public double CalculateCost()
        {
            return 3.00;
        }
    }
}
