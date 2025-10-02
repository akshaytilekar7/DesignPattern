
namespace SingletonThreadSafe;

public sealed class Singleton2
{
    private static readonly Lazy<Singleton2> _instance = new Lazy<Singleton2>(() => new Singleton2());

    public List<Country> Countries { get; private set; }

    private Singleton2()
    {
        LoadCountries();
    }

    public static Singleton2 Instance => _instance.Value;
    // Method to get the list of countries
    public List<Country> GetCountries()
    {
        return Countries;
    }

    private void LoadCountries()
    {
        Countries = new List<Country>()
        {
            new Country() { Id = 1, Name = "Germany" },
            new Country() { Id = 2, Name = "India" },
            new Country() { Id = 3, Name = "USA" }
        };
    }
}
