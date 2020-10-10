using CommandPatternDineChef.Models;
using System.Collections.Generic;

namespace CommandPatternDineChef.Interfaces
{
    public interface OrderCommand
    {
        void Execute(List<MenuItem> order, MenuItem newItem);

    }
}
