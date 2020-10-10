using zFactoryPatternModified.Factory;

namespace zFactoryPatternModified.Actions
{
    public class EmployeeAction : IEmployeeAction
    {
        private readonly IActionFactory _actionFactory;

        public EmployeeAction(IActionFactory actionFactory)
        {
            _actionFactory = actionFactory;
        }

        public void GetEmployee()
        {
            _actionFactory.AddressAction.GetAddress();
        }
    }

    public interface IEmployeeAction
    {
        void GetEmployee();
    }
}
