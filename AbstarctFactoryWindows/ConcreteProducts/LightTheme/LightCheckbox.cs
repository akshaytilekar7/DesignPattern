using AbstarctFactoryWindows.AbstractProduct;

namespace AbstarctFactoryWindows.ConcreteProducts.LightTheme;

public class LightCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("Rendering Light Checkbox");
}

