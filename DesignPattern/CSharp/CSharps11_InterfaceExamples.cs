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
            var x = a + b;
            Console.WriteLine("class method" + x);
        }

        void IMaths2.Add(int a, int b)
        {
            var x = a + b;
            Console.WriteLine("interface " + nameof(IMaths2) + " " + x);
        }

        void IMaths1.Add(int a, int b)
        {
            var x = a + b;
            Console.WriteLine("interface " + nameof(IMaths1) + " " + x);
        }
    }

    public class TestInterfaceExamples
    {
        public static void Main(string[] args)
        {
            ClsInterfaceExamples clsInterfaceExamples = new ClsInterfaceExamples();
            clsInterfaceExamples.Add(5, 3); // class method

            IMaths1 maths1 = new ClsInterfaceExamples();
            maths1.Add(5, 3); // interface IMaths1

            IMaths2 maths2 = new ClsInterfaceExamples();
            maths2.Add(5, 3); // interface IMaths2

            Console.ReadLine();
        }
    }
}
