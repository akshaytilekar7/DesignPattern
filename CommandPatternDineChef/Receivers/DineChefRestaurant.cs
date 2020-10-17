using CommandPatternDineChef.Interfaces;
using CommandPatternDineChef.Models;
using System.Collections.Generic;

namespace CommandPatternDineChef.Receivers
{
    public class DineChefRestaurant
    {
        public List<MenuItem> Orders = new List<MenuItem>();

        public void ExecuteCommand(IOrderCommand command, MenuItem item)
        {
            command.Execute(Orders, item);
        }

        public void ShowCurrentOrder()
        {
            foreach (var item in Orders)
            {
                item.DisplayOrder();
            }
        }
    }
}
