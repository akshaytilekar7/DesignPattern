using AbstarctFactoryWindows.AbstractProduct;
using AbstarctFactoryWindows.ConcreteProducts.DarkTheme;
namespace AbstarctFactoryWindows.AbstractFactory;

public class DarkThemeFactory : IThemeFactory
{
    public IButton CreateButton() => new DarkButton();
    public ICheckbox CreateCheckbox() => new DarkCheckbox();
}