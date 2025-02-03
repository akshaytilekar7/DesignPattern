using AbstarctFactoryWindows.AbstractProduct;

namespace AbstarctFactoryWindows.ConcreteProducts.DarkTheme;

public class DarkCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("Rendering Dark Checkbox");
}