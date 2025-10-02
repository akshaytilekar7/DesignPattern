
namespace RepoIQueryableAndIEnumerable;

public class Program
{
    static void Main(string[] args)
    {

        List<Employee> employee = new List<Employee>();
        var isNull = employee.IsNull();

        List<Employee> employee1 = null;
        isNull = employee1.IsNull();    



    }
}
