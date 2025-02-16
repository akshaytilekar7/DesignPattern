using CommandPatternDineChef.Models;
using System.Collections.Generic;

namespace CommandPatternDineChef.Interfaces
{
    public interface IOrderCommand
    {
        void Execute(List<MenuItem> order, MenuItem newItem);

    }
}
