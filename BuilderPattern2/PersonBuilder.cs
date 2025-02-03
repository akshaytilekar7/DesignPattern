namespace BuilderPattern2;

public class PersonBuilder
{
    private Person Person { get; set; }

    public static PersonBuilder GetBuilder()
    {
        return new PersonBuilder();
    }

    public PersonBuilder SetName(string name)
    {
        Person.Name = name;
        return this;
    }

    public PersonBuilder SetEmail(string email)
    {
        Person.Email = email;
        return this;
    }

    public Person Build()
    {
        return Person;
    }
}