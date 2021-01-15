using System;

namespace DesignPattern.CSharp
{
    public static class StaticClassWithStatic
    {
        //public int Id { get; set; } // XXXXXXXX COMPILE TIME ERROR!!!!!!!
        public static string Name { get; set; }

        static StaticClassWithStatic()
        {
            Name = "A1";
            // Id = 5; // XXXXXXXX COMPILE TIME ERROR!!!!!!!
            Console.WriteLine("Static Ctor called");
        }

        //public StaticClassWithStatic(int j) // XXXXXXXX COMPILE TIME ERROR!!!!!!!
        //{
        //    Name = "A2";
        //    Id = 5;
        //    Console.WriteLine("para Ctor called with : " + j);
        //}

        public static string GetDetails1(string name, string branch)
        {
            //Id = 5; // XXXXXXXX COMPILE TIME ERROR!!!!!!!  cant
            Name = "A2";
            return "Name: " + name + " Branch: " + branch;
        }

        //public string GetDetails(string name, string branch)
        //{
        //    Id = 5;
        //    Name = "A2";
        //    return "Name: " + name + " Branch: " + branch;
        //}

        //public static void Main()
        //{
        //    //StaticClassWithStatic obj = StaticClassWithStatic();
        //    Console.WriteLine(StaticClassWithStatic.GetDetails1("A", "B"));
        //}
    }
}

/*

    -   used when convenient container for sets of methods that just
        operate on input parameters 
        and do not have to get or set any internal instance fields. (eg : System.Math )
    -   static class is loaded by the .NET runtime when
        the program that references the class is loaded
    -   static constructor is only called one time
    -   remains in memory for the lifetime of the application domain in which your program resides.
    -   cannot contain an instance constructor.
    -   no support for static local variables 
    -   Beginning with C# 8.0, we can have a static modifier to a local function. A static local function can't capture local variables or instance state.
    -   Beginning with C# 9.0, we can have a static modifier to a lambda expression or anonymous method. A static lambda or anonymous method can't capture local variables or instance state.

*/
