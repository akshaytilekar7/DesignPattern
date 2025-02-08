using System.Collections;
namespace Enumerator2;

public class EmployeeEnumerable : IEnumerable<Employee>
{
    private readonly bool flag;

    private Employee[] list { get; set; }

    public EmployeeEnumerable(Employee[] employees, bool flag)
    {
        list = employees;
        this.flag = flag;
    }

    public IEnumerator<Employee> GetEnumerator()
    {
        return new EmployeeEnumerator(list, flag);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new EmployeeEnumerator(list, flag);
    }
}