﻿using System;

namespace DesignPattern.CSharp
{
    public class NormalClassWithStatic
    {
        public int Id { get; set; }
        public static string Name { get; set; }

        static NormalClassWithStatic()
        {
            Name = "A1";
            //Id = 5; // XXXXXXXX COMPILE TIME ERROR!!!!!!!
            Console.WriteLine("Static Ctor called");
        }

        public NormalClassWithStatic(int j)
        {
            Name = "A2";
            Id = 5;
            Console.WriteLine("para Ctor called with : " + j);
        }

        public static string StaticMethod(string name, string branch)
        {
            //Id = 5; // XXXXXXXX COMPILE TIME ERROR!!!!!!!  cant
            Name = "A2";
            return "Name: " + name + " Branch: " + branch;
        }

        public string NonStaticMethod(string name, string branch)
        {
            Id = 5;
            Name = "A2";
            return "Name: " + name + " Branch: " + branch;
        }

        public static void Main1()
        {
            NormalClassWithStatic obj = new NormalClassWithStatic(1);
            Console.WriteLine(obj.NonStaticMethod("A", "B"));

            NormalClassWithStatic ob = new NormalClassWithStatic(2);
            Console.WriteLine(ob.NonStaticMethod("AA", "BB"));
        }
    }
}
