using CommandPatternDineChef.Models;
using System.Collections.Generic;
using System.Linq;

namespace CommandPatternDineChef.Interfaces
{
    public class RemoveOrderCommand : IOrderCommand
    {
        public void Execute(List<MenuItem> order, MenuItem newItem)
        {
            order.Remove(order.First(x => x.Item == newItem.Item));
        }
    }
}
