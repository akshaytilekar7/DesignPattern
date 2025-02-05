using AbstarctFactoryWindows.AbstractProduct;

namespace AbstarctFactoryWindows.ConcreteProducts.DarkTheme;

public class DarkButton : IButton
{
    public void RenderButton() => Console.WriteLine("Rendering Dark Button");
}
