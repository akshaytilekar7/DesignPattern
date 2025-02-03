namespace BuilderPattern2;

internal class Program
{
    static void Main(string[] args)
    {
        Person person = PersonBuilder.GetBuilder()
            .SetName("Akshay")
            .SetEmail("@")
            .Build();

        Console.WriteLine(person.Name);
    }
}
