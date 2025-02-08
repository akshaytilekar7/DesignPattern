using System.Collections;
namespace Enumerator2;

public class EmployeeEnumerator : IEnumerator<Employee>
{
    private readonly bool flag;
    private Employee[] list { get; set; }
    private int Index { get; set; } = -1;

    public EmployeeEnumerator(Employee[] employees, bool flag)
    {
        list = employees;
        this.flag = flag;
    }

    public Employee Current
    {
        get
        {
            if (Index == -1 || Index >= list.Length)
                throw new InvalidOperationException();

            return list[Index];
        }
    }

    object IEnumerator.Current
    {
        get
        {
            if (Index == -1 || Index >= list.Length)
                throw new InvalidOperationException();

            return list[Index];
        }
    }

    public void Dispose() { }

    public bool MoveNext()
    {
        while (Index < list.Length)
        {
            Index++;
            if (Index < list.Length && list[Index].IsActive == flag)
                return true;
        }
        return false;
    }

    public void Reset()
    {
        Index = 0;
        list = Array.Empty<Employee>();
    }

}
