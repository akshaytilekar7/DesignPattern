using DecoratorPatternPizza.Component;

namespace DecoratorPatternPizza.ConcreteComponents
{
    public class LargePizza : IPizzaService
    {
        public string GetDescription()
        {
            return $"{GetType().Name}"; //LARGE
        }

        public double CalculateCost()
        {
            return 9.00;
        }
    }
}
