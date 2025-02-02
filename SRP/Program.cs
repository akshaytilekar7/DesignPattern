namespace SRP;


public class BaseClass
{
    public int Id { get; set; }

    public void Add(int a) => Console.WriteLine(a);
}



public class ChildClass : BaseClass
{

}


internal class Program
{
    static void Main(string[] args)
    {
        BaseClass baseClass = new ChildClass(); // valid its LSP
        ChildClass childClass = new BaseClass(); // CTE need explicit cast then RTE

        Console.ReadLine();
        Console.WriteLine("Hello, World!");
    }
}
