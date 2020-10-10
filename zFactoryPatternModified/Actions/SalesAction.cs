using zFactoryPatternModified.Factory;

namespace zFactoryPatternModified.Actions
{
    public class SalesAction : ISalesAction
    {
        private readonly IActionFactory _actionFactory;

        public SalesAction(IActionFactory actionFactory)
        {
            _actionFactory = actionFactory;
        }

        public void GetSales()
        {
        }
    }

    public interface ISalesAction
    {
        void GetSales();
    }
}
