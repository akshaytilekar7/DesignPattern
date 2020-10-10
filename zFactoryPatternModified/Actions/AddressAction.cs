using zFactoryPatternModified.Factory;

namespace zFactoryPatternModified.Actions
{
    public interface IAddressAction
    {
        void GetAddress();
    }

    public class AddressAction : IAddressAction
    {
        private readonly IActionFactory _actionFactory;

        public AddressAction(IActionFactory actionFactory)
        {
            _actionFactory = actionFactory;
        }


        public void GetAddress()
        {
        }
    }
}
