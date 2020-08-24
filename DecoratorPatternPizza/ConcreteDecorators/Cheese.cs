using DecoratorPatternPizza.Component;
using DecoratorPatternPizza.Decorator;

namespace DecoratorPatternPizza.ConcreteDecorators
{
    public class Cheese : PizzaDecorator
    {
        public Cheese(Pizza pizza) : base(pizza)
        {
            //Description = this.GetType().Name;
        }

        public override string GetDescription()
        {
            // CHEESE
            var x = Pizza.GetDescription();
            var y = this.GetType().Name;
            return $"{ x }, {y}";
        }

        public override double CalculateCost()
        {
            return Pizza.CalculateCost() + 1.25;
        }
    }
}
