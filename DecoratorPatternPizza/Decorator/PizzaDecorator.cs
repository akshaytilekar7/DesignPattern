using DecoratorPatternPizza.Component;

namespace DecoratorPatternPizza.Decorator
{
    public class PizzaDecorator : Pizza
    {
        protected Pizza Pizza;
        public PizzaDecorator(Pizza pizza)
        {
            Pizza = pizza;
        }
        public override string GetDescription()
        {
            return Pizza.GetDescription();
        }

        public override double CalculateCost()
        {
            return Pizza.CalculateCost();
        }
    }
}
