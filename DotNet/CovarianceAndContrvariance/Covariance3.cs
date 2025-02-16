namespace CovarianceAndContrvariance;

public class AnimalFactory
{
    public Func<Animal> CreateAnimal { get; set; }
}

public class Client12
{
    public static void Main12()
    {
        AnimalFactory factory = new AnimalFactory();
        factory.CreateAnimal = () => new Dog(); // Covariance: Func<Dog> to Func<Animal>

        Animal animal = factory.CreateAnimal();
        Console.WriteLine($"Created {animal.GetType().Name}");
    }
}


