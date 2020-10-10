using CommandPatternDineChef.Interfaces;
using CommandPatternDineChef.Models;
using System.Collections.Generic;

namespace CommandPatternDineChef.Receivers
{
    public class DineChefRestaurant
    {
        public List<MenuItem> Orders = new List<MenuItem>();


        public void ExecuteCommand(OrderCommand command, MenuItem item)
        {
            command.Execute(this.Orders, item);
        }

        public void ShowOrders()
        {
            foreach (var item in Orders)
            {
                item.DisplayOrder();
            }
        }
    }
}
