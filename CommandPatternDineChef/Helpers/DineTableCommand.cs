using CommandPatternDineChef.Interfaces;

namespace CommandPatternDineChef.Invokers
{
    public class DineTableCommand
    {
        //Dine table method
        public IOrderCommand GetDineCommand(int dineCommand)
        {
            switch (dineCommand)
            {
                case 1:
                    return new NewOrderCommand();
                case 2:
                    return new ModifyOrderCommand();
                case 3:
                    return new RemoveOrderCommand();
                default:
                    return new NewOrderCommand();
            }
        }
    }
}
