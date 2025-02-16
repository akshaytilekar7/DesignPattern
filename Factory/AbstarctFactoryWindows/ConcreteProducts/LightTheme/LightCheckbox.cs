using AbstarctFactoryWindows.AbstractProduct;

namespace AbstarctFactoryWindows.ConcreteProducts.LightTheme;

public class LightCheckbox : ICheckbox
{
    public void CheckValue() => Console.WriteLine("Rendering Light Checkbox");
}

