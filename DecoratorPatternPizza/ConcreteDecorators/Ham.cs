using DecoratorPatternPizza.Component;
using DecoratorPatternPizza.Decorator;

namespace DecoratorPatternPizza.ConcreteDecorators
{
    public class Ham : PizzaDecorator
    {
        public Ham(Pizza pizza) : base(pizza)
        {
            //Description = this.GetType().Name;
        }

        public override string GetDescription()
        {
            // HAM
            var x = Pizza.GetDescription();
            var y = this.GetType().Name;
            return $"{x}, {y}";
        }

        public override double CalculateCost()
        {
            return Pizza.CalculateCost() + 1.00;
        }
    }
}
