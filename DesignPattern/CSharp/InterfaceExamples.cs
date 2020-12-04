using System;
using System.Collections.Generic;
using System.Linq;

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

        static void generatesOL()
        {

        }

        // generatesOL("")
        public static void Main123()
        {

            List<string> ls = new List<string>();
            Queue<string> nodes = new Queue<string>();
            nodes.Enqueue("3");
            nodes.Enqueue("5");
            string curr = "";

            while (!nodes.Any())
            {
                curr = nodes.Dequeue();
                //nodes.pop();
                if (Convert.ToInt32(curr) >= 5) return;
                ls.Add(curr);
                nodes.Enqueue(curr + '3');
                nodes.Enqueue(curr + '5');
            }

            // sort(sol.begin(),sol.end());
            foreach (var item in ls)
            {
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        //public static void Main(string[] args)
        //{
        //    ClsInterfaceExamples clsInterfaceExamples = new ClsInterfaceExamples();
        //    clsInterfaceExamples.Add(5, 3);

        //    IMaths1 maths1 = new ClsInterfaceExamples();
        //    maths1.Add(5, 3);

        //    IMaths1 maths2 = new ClsInterfaceExamples();
        //    maths2.Add(5, 3);

        //    Console.ReadLine();
        //}
    }
}
