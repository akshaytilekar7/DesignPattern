using DecoratorPatternPizza.Component;

namespace DecoratorPatternPizza.ConcreteComponents
{
    public class LargePizza : Pizza
    {
        public override string GetDescription()
        {
            //LARGE
            return $"{GetType().Name}"; ;
        }

        public override double CalculateCost()
        {
            return 9.00;
        }
    }
}
