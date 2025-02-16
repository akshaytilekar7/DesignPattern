using CovarianceAndContrvariance123;

namespace CovarianceAndContrvariance1111111;


public class Base
{
}

public class Child : Base
{

}

public delegate void MyDelegateBase(Base obj);
public delegate void MyDelegate<in T>(T obj);

public class Service
{
    public static void ProcessBase(Base obj)
    {
        Console.WriteLine("Processing Base object");
    }

    public static void ProcessChild(Child obj)
    {
        Console.WriteLine("Processing Child object");
    }

    // Example 2 Covarience  : Use a Child type where a base type is expected (outputs)
    public Base GetBase()
    {
        return new Child();
    }

    //Note : Contravarince states - you can pass base where child is exppcted for input 
    // this is not valid here as it only apply for delgate and generis

    public Child SetChild(Child child)
    {
        return new Child();
    }
}


public class Client
{
    public Client()
    {
        MyDelegateBase myDelegate1 = Service.ProcessBase;
        myDelegate1.Invoke(new Base());

        //MyDelegateBase myDelegate2 = Service.ProcessChild;
        // myDelegate2.Invoke(new Base());

        MyDelegate<Child> myDelegateChild1 = Service.ProcessChild;
        myDelegateChild1(new Child());

        MyDelegate<Child> myDelegateChild2 = Service.ProcessBase;
        myDelegateChild1(new Child());
    }

}