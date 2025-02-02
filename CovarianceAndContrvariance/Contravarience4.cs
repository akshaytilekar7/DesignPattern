namespace CovarianceAndContrvariance5;

public class Base { }
public class Child : Base { }
public class GrandChild : Child { }

delegate Base AcceptChildNReturnBase(Child obj);

public class Program
{
    static Child MethodAccetReturnChild(Child obj)
    {
        Console.WriteLine("MethodAccetReturnChild");
        return obj;
    }

    static Base MethodAcceptChildReturnBase(Child obj)
    {
        Console.WriteLine("MethodAcceptChildReturnBase");
        return obj;
    }

    static Base MethodAcceptReturnBase(Base obj)
    {
        Console.WriteLine("MethodAccetReturnBase");
        return obj;
    }
    public static void Main(string[] args)
    {
        // Working 1
        //AcceptChildNReturnBase del = MethodAccetReturnChild;
        //del += MethodAcceptChildReturnBase;
        //del += MethodAccetReturnBase;

        // Working 2
        AcceptChildNReturnBase del = MethodAcceptReturnBase;

        var obj = del(new Child());

        Console.WriteLine("DoNe...........");
        Console.ReadLine();
    }
}