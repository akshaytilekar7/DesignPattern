using System;
namespace DesignPattern
{
    public static class StaticClassWithStatic
    {
        //public int Id { get; set; } // CTE
        public static string Name { get; set; }

        static StaticClassWithStatic()
        {
            Name = "A1";
            // Id = 5; // CTE
            Console.WriteLine("Static Ctor called");
        }

        //public StaticClassWithStatic(int j) // CTE
        //{
        //    Name = "A2";
        //    Id = 5;
        //    Console.WriteLine("para Ctor called with : " + j);
        //}

        public static string GetDetails1(string name, string branch)
        {
            //Id = 5; // CTE  cant
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
