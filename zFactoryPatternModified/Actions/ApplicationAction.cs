using zFactoryPatternModified.Factory;

namespace zFactoryPatternModified.Actions
{
    public class ApplicationAction : IApplicationAction
    {
        private readonly IActionFactory _actionFactory;

        public ApplicationAction(IActionFactory actionFactory)
        {
            _actionFactory = actionFactory;
        }

        public void GetApplication()
        {
        }
    }

    public interface IApplicationAction
    {
        void GetApplication();
    }
}
