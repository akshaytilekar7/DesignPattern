using Enumerator2;

public class Program
{
    public static void Main()
    {
        List<Employee> employees1 = null;
        Employee[] employees =
        {
         new Employee() { Id = 1,  Name = "A" , IsActive = true},
         new Employee() { Id = 2,  Name = "B", IsActive = false},
         new Employee() { Id = 3,  Name = "C", IsActive = true},
        };

        EmployeeEnumerable list = new EmployeeEnumerable(employees, true);
        var iterator = list.GetEnumerator();

        while (iterator.MoveNext())  
            Console.WriteLine(iterator.Current.ToString());  

        //foreach (var item in list)
        //    Console.WriteLine(item.Id + " " + item.Name);

        Console.WriteLine("");

        //foreach (var item in list)
        //    Console.WriteLine(item.Id + " " + item.Name);

        Console.ReadKey();
    }
}