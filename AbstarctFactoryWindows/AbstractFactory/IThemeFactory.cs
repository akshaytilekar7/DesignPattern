using AbstarctFactoryWindows.AbstractProduct;
namespace AbstarctFactoryWindows.AbstractFactory;

public interface IThemeFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}
