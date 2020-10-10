using CommandPatternDineChef.Models;
using System.Collections.Generic;
using System.Linq;

namespace CommandPatternDineChef.Interfaces
{
    public class ModifyOrderCommand : OrderCommand
    {
        public void Execute(List<MenuItem> order, MenuItem newItem)
        {
            var item = order.Where(x => x.Item == newItem.Item).First();
            item.Quantity = newItem.Quantity;
            item.Tags = newItem.Tags;
            item.TableNumber = newItem.TableNumber;
        }
    }
}
