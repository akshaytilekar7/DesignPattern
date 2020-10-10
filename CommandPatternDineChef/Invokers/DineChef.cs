using CommandPatternDineChef.Interfaces;
using CommandPatternDineChef.Models;
using CommandPatternDineChef.Receivers;

namespace CommandPatternDineChef.Invokers
{
    public class DineChef
    {
        private DineChefRestaurant dineChefRestaurant = new DineChefRestaurant();
        private OrderCommand orderCommand;

        public void ExecuteCommand(int dineCommand, MenuItem item)
        {
            orderCommand = new DineTableCommand().GetDineCommand(dineCommand);
            dineChefRestaurant.ExecuteCommand(orderCommand, item);
        }

        public void ShowCurrentOrder()
        {
            dineChefRestaurant.ShowOrders();
        }
    }
}
