using System;

namespace DesignPattern.CSharp
{
    interface IMaths1
    {
        void Add(int a, int b);
    }
    interface IMaths2
    {
        void Add(int a, int b);
    }

    public class ClsInterfaceExamples : IMaths1, IMaths2
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("interface IMaths1");
        }

        void IMaths2.Add(int a, int b)
        {
            Console.WriteLine("interface IMaths1");
        }

        void IMaths1.Add(int a, int b)
        {
            Console.WriteLine("class method");
        }
    }

    public class TestInterfaceExamples
    {
        public static void Main(string[] args)
        {
            ClsInterfaceExamples clsInterfaceExamples = new ClsInterfaceExamples();
            clsInterfaceExamples.Add(5, 3);

            IMaths1 maths1 = new ClsInterfaceExamples();
            maths1.Add(5, 3);

            IMaths1 maths2 = new ClsInterfaceExamples();
            maths2.Add(5, 3);

            Console.ReadLine();
        }

    }
}