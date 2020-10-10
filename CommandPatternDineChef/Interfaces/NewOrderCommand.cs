using CommandPatternDineChef.Models;
using System.Collections.Generic;

namespace CommandPatternDineChef.Interfaces
{
    public class NewOrderCommand : OrderCommand
    {
        public void Execute(List<MenuItem> order, MenuItem newItem)
        {
            order.Add(newItem);
        }
    }
}
