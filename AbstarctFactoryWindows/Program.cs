using AbstarctFactoryWindows.AbstractFactory;

namespace AbstarctFactoryWindows;

internal class Program
{
    static void Main(string[] args)
    {
        // Way 1
        var factory = ThemeFactory.GetTheme(Theme.Dark);
        var result1 = factory.CreateButton();
        var result2 = factory.CreateCheckbox();

        result1.RenderButton();
        result2.CheckValue();


        // Way 2
        IThemeFactory lightFactory = new LightThemeFactory();
        var lightApp = new Application(lightFactory);
        lightApp.RenderUI(); // Output: Rendering Light Button, Rendering Light Checkbox

        IThemeFactory darkFactory = new DarkThemeFactory();
        var darkApp = new Application(darkFactory);
        darkApp.RenderUI(); // Output: Rendering Dark Button, Rendering Dark Checkbox
    }
}
