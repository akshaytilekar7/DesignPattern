using System.Collections;
namespace Enumerator2;

public class EmployeeEnumerator : IEnumerator<Employee>
{
    private readonly bool flag;
    private Employee[] array { get; set; }
    private int index { get; set; } = -1;

    public EmployeeEnumerator(Employee[] employees, bool flag)
    {
        array = employees;
        this.flag = flag;
    }

    public Employee Current
    {
        get
        {
            if (index == -1 || index >= array.Length)
                throw new InvalidOperationException();

            return array[index];
        }
    }

    object IEnumerator.Current
    {
        get
        {
            if (index == -1 || index >= array.Length)
                throw new InvalidOperationException();

            return array[index];
        }
    }

    public void Dispose() { }

    public bool MoveNext()
    {
        while (index < array.Length)
        {
            index++;
            if (index < array.Length && array[index].IsActive == flag)
                return true;
        }
        return false;
    }

    public void Reset()
    {
        //index = -1;
        //array = Array.Empty<Employee>();
    }

}
