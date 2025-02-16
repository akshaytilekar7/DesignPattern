namespace CovarianceAndContrvariance;

public class Person { public string Name { get; set; } }
public class Employee : Person { }

public class PersonComparer : IComparer<Person>
{
    public int Compare(Person x, Person y) => x.Name.CompareTo(y.Name);
}

public class Client1
{
    public static void Main12()
    {
        IComparer<Person> personComparer = new PersonComparer();

        // Use a base type where a child type is expected (inputs).
        // Contravariance: IComparer<Person> to IComparer<Employee>
        IComparer<Employee> employeeComparer = personComparer; 

        List<Employee> employees = new List<Employee> { new Employee(), new Employee() };
        employees.Sort(employeeComparer); // Works because Employee is a Person
    }
}