using AbstarctFactoryWindows.AbstractFactory;
using AbstarctFactoryWindows.AbstractProduct;

namespace AbstarctFactoryWindows;

public class Application
{
    private readonly IButton _button;
    private readonly ICheckbox _checkbox;

    public Application(IThemeFactory factory)
    {
        _button = factory.CreateButton();
        _checkbox = factory.CreateCheckbox();
    }

    public void RenderUI()
    {
        _button.RenderButton();
        _checkbox.CheckValue();
    }
}
