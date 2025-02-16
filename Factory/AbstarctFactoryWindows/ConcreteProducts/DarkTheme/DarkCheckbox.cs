using AbstarctFactoryWindows.AbstractProduct;

namespace AbstarctFactoryWindows.ConcreteProducts.DarkTheme;

public class DarkCheckbox : ICheckbox
{
    public void CheckValue() => Console.WriteLine("Rendering Dark Checkbox");
}