using System;

// BEST FILE
//https://medium.com/c-programming/passing-parameters-in-c-3e4ead58e384
//https://medium.com/c-programming/c-memory-management-part-1-c03741c24e4b

internal class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

namespace A_ValueType
{
    class Program
    {
        static void Double(int number)
        {
            Console.WriteLine($"Inside function => Value before change: {number}");
            number *= 2;
            Console.WriteLine($"Inside function => Value after change: {number}");
        }

        static void Main1(string[] args)
        {
            int value = 5;
            Console.WriteLine($"Inside main => Value before function call: {value}");
            Double(value);
            Console.WriteLine($"Inside main => Value after function call: {value}");

            Console.ReadLine();
        }
    }

    // 5 5 10 5
}

namespace A_ValueType_ByReferenceType
{
    class Program
    {
        static void Double(ref int number)
        {
            Console.WriteLine($"Inside function => Value before change: {number}");
            number *= 2;
            Console.WriteLine($"Inside function => Value after change: {number}");
        }

        static void Main1(string[] args)
        {
            int value = 5;
            Console.WriteLine($"Inside main => Value before function call: {value}");
            Double(ref value);
            Console.WriteLine($"Inside main => Value after function call: {value}");

            Console.ReadLine();
        }
    }
    // 5 5 10 10 // CHANGE PERSIST AFTER FUN CALL
}

namespace A_ReferenceType
{
    class Program
    {

        // both variables point to the same location of the heap.
        static void IncrementAge(Person person)
        {
            Console.WriteLine($"Inside function => {person.Name}'s age before change: {person.Age}");
            person.Age += 1;
            Console.WriteLine($"Inside function => {person.Name}'s age after change: {person.Age}");
            person = null;
        }

        // person and alice variables share the same location, 
        // when we set person to null, alice variable lost the connection to the object on the heap, 
        // so we cannot access Alice’s age any more.
        static void IncrementAge(ref Person person)
        {
            Console.WriteLine($"Inside function => {person.Name}'s age before change: {person.Age}");
            person.Age += 1;
            Console.WriteLine($"Inside function => {person.Name}'s age after change: {person.Age}");
            person = null;
        }

        static void Main1(string[] args)
        {
            var alice = new Person { Name = "Alice", Age = 17 };
            Console.WriteLine($"Inside main => {alice.Name}'s age before function call: {alice.Age}");
            IncrementAge(alice);
            Console.WriteLine($"Inside main => {alice.Name}'s age after function call: {alice.Age}");

            Console.WriteLine("************");

            alice = new Person { Name = "Alice", Age = 17 };
            Console.WriteLine($"Inside main => {alice.Name}'s age before function call: {alice.Age}");
            IncrementAge(ref alice);
            Console.WriteLine($"Inside main => {alice.Name}'s age after function call: {alice.Age}"); // EX thrown

            Console.ReadLine();
        }
    }

    //// IncrementAge(alice); 17 17 18 18   
    //// IncrementAge(ref alice);  17 17 18 Ex - Object refrance not set to instance 
    // because noraml paramter 

}

namespace A_ValeType_Out
{
    class Program
    {
        static void TyrOutParameter(out int number)
        {
            //This will get compile time error => Use of unassigned out parameter 'number'
            //Console.WriteLine(number);

            //This will also get compile time error => Use of unassigned out parameter 'number'
            //number += 10;

            //Assignment - this must happen before the method can complete normally
            //Otherwise it will get compile time error => 
            //The out parameter 'number' must be assigned to before control leaves the current method
            number = 20;
        }

        static void Main1(string[] args)
        {
            //This initialization has no effect
            int value = 5;
            TyrOutParameter(out value);
            Console.WriteLine($"Inside main => Value after function call: {value}");
            Console.ReadLine();
        }
    }
}

namespace A_In_Csharp7_2
{
    // IN keyword is used to pass a PARAMETER BY REFERENCE FOR INPUT. in arguments cannot be modified by the called method.
    // Variables passed as in arguments must be initialized before being passed in a method call
    // in modifier is optional at the method call. It is only required in the method declaration.
    class Program
    {
        static void TyrInParameter(in int number)
        {
            //This will get compile time error => Cannot assign to variable 'in int' because it is a readonly variable 
            //number = 20;

            Console.WriteLine($"Inside function => Value : {number}");
        }

        static void Main1(string[] args)
        {
            int value = 5;

            //Both method calls are legal
            TyrInParameter(value);
            TyrInParameter(in value);

            Console.WriteLine($"Inside main => Value after function call: {value}");

            Console.ReadLine();
        }
    }
}

//ref keyword is used to pass a parameter by reference for input and output.
//ref parameter must be initialized before it is passed.

//out keyword is used to pass a parameter by reference for output.
//It means we cannot pass a variable value as input using out parameter.
//Variables passed as out arguments DO NOT HAVE TO BE INITIALIZED BEFORE being passed in a method call.
//EVEN IF IT IS INITIALIZED, THIS VALUE CANNOT BE ACCESSED INSIDE THE METHOD.
//called method is required to assign a value to out argument before the

// VALID
//      public void A(int a)      public void A(ref int a) // can overload normal para and ref/out
// INVALID
//      public void A(out int a)  public void A(ref int a) // cant overload ref and out

// INVALID for in, ref, and out : Async methods and Iterator methods (yield return or yield break)