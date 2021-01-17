using System;

namespace DesignPattern.CSharp
{
    // https://medium.com/c-programming/c-memory-management-part-3-garbage-collection-18faf118cbf1

    /*
    GARBAGE COLLECTOR : EXPLICITLY RELEASE THOSE RESOURCES AFTER USING THEM IN OUR APPLICATIONS

        1. why need Dispose()
           FINALIZERS CANNOT BE CALLED EXPLICITLY, THEY ARE CALLED BY THE GARBAGE COLLECTOR (GC) 
           So to RELEASE MEMORY MANUALLY implement IDisposable interface
        2. why need dtor/finalize when we have Dispose()
           by ADDING THE FINALIZER (Destructor) DURING THE IMPLEMENTATION OF THE DISPOSE PATTERN 
           BECOMES A SAFEGUARD TO CLEAN UP THE RESOURCES IF THE CLIENT DOES NOT CALL THE DISPOSE METHOD.

          SuppressFinalize only be called by a class that has a finalizer. 
          It's informing the Garbage Collector (GC) that this object was cleaned up fully.
     */

    #region MEMORY_MANAGEMENT_PART_1
    /*

    1.  MEMORY MANAGEMENT - PART 1


    Stack :
        -   Variables allocated on the stack are stored directly to the memory
        -   Access to this memory is very fast
        -   its allocation is done when the program is compiled
        -   The method then pushes data onto the stack as it executes. 
            When the method completes, the CLR resets the stack to its previous bookmark, popping all the method’s memory allocations is one simple operation.
    Heap 
        -   It allows objects to be allocated or deallocate in a random order.
        -   Variables allocated on the heap have their memory allocated at run time 
        -   slower
        -   The heap requires the overhead of a garbage collector to keep things in order

    A value type holds the data within its own memory location. [ bool, byte, char, decimal, double, float, int, long, uint, ulong, ushort, enum, struct]
    A reference type contains a pointer to another memory location that holds the real data. [class, interface, delegate, string, object, dynamic, arrays]

    */

    #endregion MEMORY_MANAGEMENT_PART_1

    #region MEMORY_MANAGEMENT_PART_2

    /*
    GARBAGE COLLECTOR : EXPLICITLY RELEASE THOSE RESOURCES AFTER
                        USING THEM IN OUR APPLICATIONS
    1. using finalizers (ie, Destructor)
    -   final clean-up when a class instance is being collected by the garbage collector
    -   class can have only one finalizer.
    -   finalizer does not have modifiers or parameters.
    -   FINALIZERS CANNOT BE CALLED EXPLICITLY, THEY ARE CALLED BY THE GARBAGE COLLECTOR (GC) 

    2. implementing Dispose method from the IDisposable interface
    -    AS FINALIZE CANT CALL DIRECTLY, 
         So what about huge resources how release then explicitly manually?
         ANSWER : DISPOSE METHOD FROM IDISPOSABLE INTERFACE.
     */

    class DatabaseConnection : IDisposable
    {

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls
        protected virtual void RemoveUnmanageData(bool disposing)
        {
            if (disposedValue == false)
            {
                Console.WriteLine("This is the first call to Dispose. Necessary clean-up will be done!");

                if (disposing)
                {
                    Console.WriteLine("Explicit call: Dispose() call by user.");
                }
                else
                {
                    Console.WriteLine("Implicit call: Dispose() called by finalization.");
                }

                Console.WriteLine("Unmanaged resources are cleaned up here.");

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
            RemoveUnmanageData(false);
        }

        public void Dispose()
        {
            RemoveUnmanageData(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion

    }

    #region Call Dispose method explicitly
    // 1. Dispose method explicitly:
    class Program1
    {
        static void main1(string[] args)
        {
            var connection = new DatabaseConnection();
            try
            {
                //Write your operational code here
            }
            finally
            {
                connection.Dispose(); // IMP ********* IMP// IMP ********* IMP// IMP ********* IMP
            }
        }
    }

    #endregion Call Dispose method explicitly


    #region call Dispose is using using statement
    //2. call Dispose is using using statement:

    class Program2
    {
        static void main1(string[] args)
        {
            using (var connection = new DatabaseConnection())
            {
                //Write your operational code here
            }
            //NO CALL TO DISPOSE METHOD BECAUSE THE USING STATEMENT HANDLES THAT AUTOMATICALLY. ********
        }
    }

    #endregion call Dispose is using using statement


    #region Call Dispose method more than once and see the output:
    //3. let’s call Dispose method more than once and see the output:

    class Program3
    {
        static void main1(string[] args)
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
    //  Explicit call: Dispose() call by user.
    //  Unmanaged resources are cleaned up here
    //  Dispose is called more than one time. No need to clean up!
    //  Dispose is called more than one time. No need to clean up!

    //4. LET’S SEE WHAT HAPPENS IF WE DON’T CALL THE DISPOSE METHOD EXPLICITLY:

    #endregion Call Dispose method more than once and see the output:


    #region Dont call the Dispose method explicitly:
    class Program4
    {
        static void main1(string[] args)
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
    //  Implicit call: Dispose() called by finalization.
    //  Unmanaged resources are cleaned up here

    //*******************************IMP***************//
    // SO ADDING THE FINALIZER (Destructor) DURING THE
    //  IMPLEMENTATION OF THE DISPOSE PATTERN 
    // BECOMES A SAFEGUARD TO CLEAN UP THE RESOURCES IF THE CLIENT DOES NOT
    //  CALL THE DISPOSE METHOD.

    #endregion Dont call the Dispose method explicitly:


    #endregion MEMORY_MANAGEMENT_PART_2

    #region MEMORY_MANAGEMENT_PART_3

    // Garbage Collector serves as an automatic memory manager
    // manages the allocation and release of memory for your application.
    // Allocates objects on the managed heap efficiently.
    // Reclaims objects that are no longer being used, clears their memory, and keeps the memory available for future allocations.
    // Provides memory safety by making sure that an object cannot use the content of another object.
    // The GC allocates and frees virtual memory for you on the managed heap.
    // heap has 2 type : A] Large object heap b] small object heap

    /*
    -   The heap is organized into generations so it can handle long-lived and short-lived objects

    Generation 0:
        -   This is the youngest generation and contains short-lived objects
        -   Newly allocated objects form a new generation of objects and are implicitly Gen 0 collections unless 
            they are large objects, in which case they go on the large object heap in a Gen 2 collection.
        -   Objects that survive a Gen 0 garbage collection are promoted to Gen 1.

    Generation 1: 
        -   This generation contains short-lived objects and acts as a buffer between short-lived objects and long-lived objects. 
        -   Objects that survive a Gen 1 garbage collection are promoted to Gen 2.

    Generation 2:
        -   generation contains long-lived objects. (Example : static data)

    How Garbage Collector Works

    1. Marking Phase : Finds and creates a list of all live objects.
    2. Relocating Phase : Updates the references to the objects that will be compacted.
    3. Compacting Phase : 
        -   Reclaims the space occupied by the dead objects
        -   compacts the surviving objects.

    HOE GC DETERMINE WHETHER OBJECTS ARE LIVE:
    1. Stack roots: Stack variables provided by the just-in-time (JIT) compiler and stack walker
    2. Garbage collection handles: Handles that point to managed objects and that can be allocated by user code or by the CLR.
    3. Static data: Static objects in application domains that could be referencing other objects.

    */

    #endregion MEMORY_MANAGEMENT_PART_3
}