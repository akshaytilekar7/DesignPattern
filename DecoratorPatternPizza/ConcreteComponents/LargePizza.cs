using DecoratorPatternPizza.Component;

namespace DecoratorPatternPizza.ConcreteComponents
{
    public class LargePizza : Pizza
    {
        public override string GetDescription()
        {
            return $"{GetType().Name}"; //LARGE
        }

        public override double CalculateCost()
        {
            return 9.00;
        }
    }
}
