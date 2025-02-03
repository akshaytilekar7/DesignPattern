using AbstarctFactoryWindows.AbstractFactory;

namespace AbstarctFactoryWindows;

internal class Program
{
    static void Main(string[] args)
    {
        IThemeFactory lightFactory = new LightThemeFactory();
        var lightApp = new Application(lightFactory);
        lightApp.RenderUI(); // Output: Rendering Light Button, Rendering Light Checkbox

        IThemeFactory darkFactory = new DarkThemeFactory();
        var darkApp = new Application(darkFactory);
        darkApp.RenderUI(); // Output: Rendering Dark Button, Rendering Dark Checkbox
    }
}
