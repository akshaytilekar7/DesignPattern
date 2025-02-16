namespace CovarianceAndContrvariance;

public class Animal { }
public class Dog : Animal { }

public class AnimalService
{
    public void ProcessAnimals(IEnumerable<Animal> animals)
    {
        foreach (var animal in animals)
            Console.WriteLine($"Processing {animal.GetType().Name}");
    }

    public Animal GetAnimal()
    {
        // use child where base was expeted
        // Covariance: Dog is returned as Animal
        return new Dog(); 
    }
}

public class Client2
{
    public static void Main12()
    {
        List<Dog> dogs = new List<Dog> { new Dog(), new Dog() };

        AnimalService animalService = new AnimalService();

        // Covariance: List<Dog> to IEnumerable<Animal>
        // use child where base was expeted
        animalService.ProcessAnimals(dogs); 

        // Example 2
        AnimalService service = new AnimalService();
        Animal animal = service.GetAnimal();
        Console.WriteLine($"Returned {animal.GetType().Name}");
    }
}