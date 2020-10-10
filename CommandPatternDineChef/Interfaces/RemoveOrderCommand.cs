using CommandPatternDineChef.Models;
using System.Collections.Generic;
using System.Linq;

namespace CommandPatternDineChef.Interfaces
{
    public class RemoveOrderCommand : OrderCommand
    {
        public void Execute(List<MenuItem> order, MenuItem newItem)
        {
            order.Remove(order.Where(x => x.Item == newItem.Item).First());
        }
    }
}
