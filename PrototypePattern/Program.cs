using System;

namespace PrototypePattern
{

    //BORING DESIGN PATTERN
    // - PrototypePattern -- deepCopy and shallowCopy
    // - Immutable Design Pattern -- 1. remove setter 2. assign in Ctor 3. add readonly property
    // - Composite Pattern -- normal interface implementation
    // - Command pattern (behaviour pattern) - 

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person
            {
                Age = 10,
                BirthDate = new DateTime(),
                Name = "Akshay",
                IdInfo = new IdInfo(100)
            };

            Person p2 = p1.ShallowCopy();
            Person p3 = p1.DeepCopy();

            // Display values of p1, p2 and p3.
            Console.WriteLine("Original values of p1, p2, p3:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);

            // Change the value of p1 properties and display the values of p1,
            // p2 and p3.
            p1.Age = 20;
            p1.BirthDate = new DateTime().AddMonths(2);
            p1.Name = "Yash";
            p1.IdInfo.IdNumber = 200;
            Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values (reference values have changed):");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values (everything was kept the same):");
            DisplayValues(p3);

            Console.ReadKey();
        }

        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
                p.Name, p.Age, p.BirthDate);
            Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
        }
    }
}
