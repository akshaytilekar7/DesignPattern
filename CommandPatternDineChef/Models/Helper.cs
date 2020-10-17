using CommandPatternDineChef.ConcreteClass;
using CommandPatternDineChef.Interfaces;

namespace CommandPatternDineChef.Models
{
    public static class Helper
    {
        public static IOrderCommand GetCmd(Cmd dineCommand)
        {
            switch (dineCommand)
            {
                case Cmd.NewOrder:
                    return new NewOrderCommand();
                case Cmd.ModifyOrder:
                    return new ModifyOrderCommand();
                case Cmd.RemoveOrder:
                    return new RemoveOrderCommand();
                default:
                    return new NewOrderCommand();
            }
        }
    }

    public enum Cmd
    {
        NewOrder = 1,
        ModifyOrder = 2,
        RemoveOrder = 3
    }
}
