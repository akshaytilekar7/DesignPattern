using DecoratorPatternPizza.Component;

namespace DecoratorPatternPizza.Decorator
{
    public class PizzaDecorator : Pizza
    {
        protected Pizza PizzaDeco;
        public PizzaDecorator(Pizza pizza)
        {
            PizzaDeco = pizza;
        }
        public override string GetDescription()
        {
            return PizzaDeco.GetDescription();
        }

        public override double CalculateCost()
        {
            return PizzaDeco.CalculateCost();
        }
    }
}
