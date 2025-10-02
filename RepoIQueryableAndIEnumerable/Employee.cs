namespace RepoIQueryableAndIEnumerable;

public class Employee
{
    public int Id { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }
}


public static class EmployeeExtention
{
    public static bool IsNull(this List<Employee> e)
    {
        return e is null;
    }

    public static bool MyAny(this List<Employee> source)
    {
        if (source == null) throw new ArgumentNullException(nameof(source));

        return source is null;
    }
}