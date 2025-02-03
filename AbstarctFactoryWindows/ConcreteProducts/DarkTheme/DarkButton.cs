using AbstarctFactoryWindows.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctFactoryWindows.ConcreteProducts.DarkTheme;

public class DarkButton : IButton
{
    public void Render() => Console.WriteLine("Rendering Dark Button");
}
