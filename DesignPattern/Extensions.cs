using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern
{
    public static class Extensions
    {
        public static bool IsLengthGreaterThanSpecifiedNumber<T>(this IEnumerable<T> enumerable, int number)
        {
            return enumerable.ToList().Count > number; // or Take(number).Count()
        }
    }

    interface IMaths1
    {
        void Add(int a, int b);

    }
    interface IMaths2
    {
        void Add(int a, int b);

    }
    public class Test : IMaths1, IMaths2
    {
        void IMaths1.Add(int a, int b)
        {
            Console.WriteLine("interface IMaths1");
        }

        void IMaths2.Add(int a, int b)
        {
            Console.WriteLine("interface IMaths1");
        }

        public void Add(int a, int b)
        {
            Console.WriteLine("class method");
        }

        public Test()
        {


        }
    }

    public class Employee
    {
        public string Name { get; set; }
    }
}
