using zFactoryPatternModified.Actions;

namespace zFactoryPatternModified.Factory
{
    public interface IActionFactory
    {
        IApplicationAction ApplicationAction { get; }

        IAddressAction AddressAction { get; }

        ISalesAction SalesAction { get; }

        IEmployeeAction EmployeeAction { get; }

    }
}
