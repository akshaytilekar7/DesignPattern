using DecoratorPatternPizza.Component;

namespace DecoratorPatternPizza.ConcreteComponents
{
    public class SmallPizza : Pizza
    {
        public override string GetDescription()
        {

            return $"{this.GetType().Name}"; //SMALL
        }

        public override double CalculateCost()
        {
            return 3.00;
        }
    }
}
