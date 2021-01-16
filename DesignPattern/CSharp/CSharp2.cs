using System;

namespace DesignPattern.CSharp
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    class Run
    {
        public static void Main1()
        {
            Student s1 = new Student() { Id = 1, Name = "A" };
            Student s2 = new Student() { Id = 213, Name = "A" };

            Console.WriteLine(2 == 2.0); // true
            Console.WriteLine(2.Equals(2.0)); // true


            Console.ReadLine();

        }
    }
}
