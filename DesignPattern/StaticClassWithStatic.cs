using System;
namespace DesignPattern
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
