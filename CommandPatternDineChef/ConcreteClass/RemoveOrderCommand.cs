using System.Collections.Generic;
using System.Linq;
using CommandPatternDineChef.Interfaces;
using CommandPatternDineChef.Models;

namespace CommandPatternDineChef.ConcreteClass
{
    public class RemoveOrderCommand : IOrderCommand
    {
        public void Execute(List<MenuItem> order, MenuItem newItem)
        {
            order.Remove(order.First(x => x.Item == newItem.Item));
        }
    }
}
