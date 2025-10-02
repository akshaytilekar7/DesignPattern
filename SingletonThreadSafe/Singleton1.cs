namespace SingletonThreadSafe;

public sealed class Singleton1
{
    private static Singleton1 _instance = null;
    public List<Country> Countries { get; private set; }
    private static readonly object _lock = new object();

    private Singleton1()
    {
    }

    public static Singleton1 Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new Singleton1();
                }
            }
            return _instance;
        }
    }

    public List<Country> GetCountries()
    {
        if (Countries is null)
        {
            lock (_lock)
            {
                if (Countries is null)
                {
                    LoadCountries();
                }
            }
        }

        return Countries;
    }

    private void LoadCountries()
    {
        Countries = new List<Country>()
        {
            new Country() {Id = 1, Name = "German" },
            new Country() {Id = 2, Name = "India" },
            new Country() {Id = 3, Name = "USA" }
        };
    }
}

