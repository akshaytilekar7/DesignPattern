using DecoratorPatternPizza.Component;

namespace DecoratorPatternPizza.Decorator
{
    public class PizzaDecorator : IPizzaService
    {
        protected IPizzaService PizzaDeco;
        public PizzaDecorator(IPizzaService pizza)
        {
            PizzaDeco = pizza;
        }
        public virtual string GetDescription()
        {
            return PizzaDeco.GetDescription();
        }

        public virtual double CalculateCost()
        {
            return PizzaDeco.CalculateCost();
        }
    }
}
