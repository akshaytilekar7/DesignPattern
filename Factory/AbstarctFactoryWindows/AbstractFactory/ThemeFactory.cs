namespace AbstarctFactoryWindows.AbstractFactory;
public class ThemeFactory
{
    public static IThemeFactory GetTheme(Theme theme)
    {
        switch (theme)
        {
            case Theme.Dark: return new DarkThemeFactory();
            case Theme.Light: return new LightThemeFactory();
            default: throw new ArgumentException();
        }
    }
}
