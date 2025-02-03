using AbstarctFactoryWindows.AbstractProduct;
using AbstarctFactoryWindows.ConcreteProducts.LightTheme;
namespace AbstarctFactoryWindows.AbstractFactory;

public class LightThemeFactory : IThemeFactory
{
    public IButton CreateButton() => new LightButton();
    public ICheckbox CreateCheckbox() => new LightCheckbox();
}
