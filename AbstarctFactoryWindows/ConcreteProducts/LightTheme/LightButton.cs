using AbstarctFactoryWindows.AbstractProduct;
namespace AbstarctFactoryWindows.ConcreteProducts.LightTheme;

public class LightButton : IButton
{
    public void RenderButton() => Console.WriteLine("Rendering Light Button");
}

