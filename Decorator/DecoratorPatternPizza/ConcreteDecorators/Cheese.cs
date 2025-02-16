using DecoratorPatternPizza.Component;
using DecoratorPatternPizza.Decorator;

namespace DecoratorPatternPizza.ConcreteDecorators
{
    public class Cheese : PizzaDecorator
    {
        public Cheese(IPizzaService pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            var x = PizzaDeco.GetDescription();
            var y = this.GetType().Name; // CHEESE
            return $"{x}, {y}";
        }

        public override double CalculateCost()
        {
            return PizzaDeco.CalculateCost() + 1.25;
        }
    }
}
