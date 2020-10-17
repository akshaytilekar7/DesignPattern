using CommandPatternDineChef.Models;
using System.Collections.Generic;
using System.Linq;

namespace CommandPatternDineChef.Interfaces
{
    public class ModifyOrderCommand : IOrderCommand
    {
        public void Execute(List<MenuItem> order, MenuItem newItem)
        {
            var item = order.First(x => x.Item == newItem.Item);
            item.Quantity = newItem.Quantity;
            item.Tags = newItem.Tags;
            item.TableNumber = newItem.TableNumber;
        }
    }
}
