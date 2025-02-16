namespace Enumerator2;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }

    public override string ToString()
    {
        return Id + " " + Name + " " + IsActive;
    }

}