using DecoratorPatternPizza.Component;

namespace DecoratorPatternPizza.ConcreteComponents
{
    public class SmallPizza : Pizza
    {
        public override string GetDescription()
        {
            //SMALL
            return $"{this.GetType().Name}";
        }

        public override double CalculateCost()
        {
            return 3.00;
        }
    }
}
