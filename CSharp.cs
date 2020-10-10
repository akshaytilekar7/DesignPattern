
/*
Generics

design interfaces and generic classes that have the same implementation, regardless of the type of parameter, increasing the flexibility of use in a safe way
we apply constraints to generics using “where” keyword.Constraints will result in compile time error if you instantiate with placeholder that is not defined in constraints.

*/

//Declaring multiple Generic with single & multiple class names using interface
class ModelExample3 { }
interface IModelExample { }

class Test
{
    public static void MultipleGenericExample1<T1, T2>(T1 t1, T2 t2) where T1 : ModelExample3, new() where T2 : IModelExample
    {
        Console.WriteLine(String.Format("T1 Attributes {0}  {1}", t1.attribute1, t1.attribute2));
        Console.WriteLine(String.Format("T2 Attributes {0}  {1}", t2.attribute1, t2.attribute2));
    }
}


/*
  
1.  MEMORY MANAGEMENT - PART 1


Stack :
    -   Variables allocated on the stack are stored directly to the memory
    -   Access to this memory is very fast
    -   its allocation is done when the program is compiled
    -   The method then pushes data onto the stack as it executes. 
        When the method completes, the CLR resets the stack to its previous bookmark, popping all the method’s memory allocations is one simple operation.
Heap 
    -   It allows objects to be allocated or deallocated in a random order.
    -   Variables allocated on the heap have their memory allocated at run time 
    -   slower
    -    The heap requires the overhead of a garbage collector to keep things in order

A value type holds the data within its own memory location. [ bool, byte, char, decimal, double, float, int, long, uint, ulong, ushort, enum, struct]
A reference type contains a pointer to another memory location that holds the real data. [class, interface, delegate, string, object, dynamic, arrays]




GARBAGE COLLECTOR : EXPLICITLY RELEASE THOSE RESOURCES AFTER USING THEM IN OUR APPLICATIONS
1. using finalizers
-   also known as Destructor
-   final clean-up when a class instance is being collected by the garbage collector
-   class can have only one finalizer.
-   finalizer does not have modifiers or parameters.
-   FINALIZERS CANNOT BE CALLED EXPLICITLY, THEY ARE CALLED BY THE GARBAGE COLLECTOR (GC) 

2. implementing Dispose method from the IDisposable interface
-    As finalize cant call direclty, so what about huge resources how release then explicitly manually ANSWER : DISPOSE METHOD FROM IDISPOSABLE INTERFACE.
      
  */

class DatabaseConnection : IDisposable
{

    #region IDisposable Support
    private bool disposedValue = false; // To detect redundant calls

    protected virtual void Dispose(bool disposing)
    {
        if (disposedValue == false)
        {
            Console.WriteLine("This is the first call to Dispose. Necessary clean-up will be done!");

            if (disposing) 
            {
                // Explicit call
                // TODO: dispose managed state (managed objects).
                Console.WriteLine("Explicit call: Dispose is called by the user.");
            }
            else
            {
                Console.WriteLine("Implicit call: Dispose is called through finalization.");
            }

            // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
            Console.WriteLine("Unmanaged resources are cleaned up here.");

            // TODO: set large fields to null.
            disposedValue = true;
        }
        else
        {
            Console.WriteLine("Dispose is called more than one time. No need to clean up!");
        }
    }

    // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
    ~DatabaseConnection()
    {
        // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        Dispose(false);
    }

    // This code added to correctly implement the disposable pattern.
    public void Dispose()
    {
        // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        Dispose(true);
        // TODO: uncomment the following line if the finalizer is overridden above.
        GC.SuppressFinalize(this);
    }
    #endregion

}

//CALL
// 1. Dispose method explicitly:

class Program
{
    static void Main(string[] args)
    {
        var connection = new DatabaseConnection();
        try
        {
            //Write your operational code here
        }
        finally
        {
            connection.Dispose(); // IMP ********* IMP
        }
    }
}


//2. call Dispose is using using statement:

class Program
{
    static void Main(string[] args)
    {
        using (var connection = new DatabaseConnection())
        {
            //Write your operational code here
        }
        //NO CALL TO DISPOSE METHOD BECAUSE THE USING STATEMENT HANDLES THAT AUTOMATICALLY. ********
    }
}


//3. let’s call Dispose method more than once and see the output:

class Program
{
    static void Main(string[] args)
    {
        var connection = new DatabaseConnection();
        try
        {
            //Write your operational code here
        }
        finally
        {
            connection.Dispose();
            connection.Dispose();
            connection.Dispose();
        }
    }
}


//. output 
//  This is the first call to Dispose. Necessary clean-up will be done!
//  Explicit call: Dispose is called by the user.
//  Unmanaged resources are cleaned up here
//  Dispose is called more than one time. No need to clean up!
//  Dispose is called more than one time. No need to clean up!

//4. LET’S SEE WHAT HAPPENS IF WE DON’T CALL THE DISPOSE METHOD EXPLICITLY:

class Program
{
    static void Main(string[] args)
    {
        var connection = new DatabaseConnection();
        try
        {
            //Write your operational code here
        }
        finally
        {
            //connection.Dispose();
        }
    }
}

// output 
//  This is the first call to Dispose. Necessary clean-up will be done!
//  Implicit call: Dispose is called through finalization.
//  Unmanaged resources are cleaned up here

//*******************************
// SO ADDING THE FINALIZER DURING THE IMPLEMENTATION OF THE DISPOSE PATTERN BECOMES A SAFEGUARD TO CLEAN UP THE RESOURCES IF THE CLIENT DOES NOT CALL THE DISPOSE METHOD.


// https://medium.com/c-programming/c-memory-management-part-3-garbage-collection-18faf118cbf1
