namespace MyApp;


public class Demo
{
    public readonly string name = "A";

    public Demo(string n)
    {
        name = n;
    }
}

public static class DemoS
{
    public static readonly string staticName = "A";
    public static string normalName = "A";

    static DemoS()
    {
        staticName = "B";
        normalName = "BTransactionDemo";
    }
    public static void Change(string n)
    {
        // staticName = n; // 
        normalName = n;
    }

}

public class Test
{
    static void Main(string[] args)
    {

        // Start();
    }
}
