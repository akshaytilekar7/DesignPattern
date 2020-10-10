using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using zFactoryPatternModified.Factory;

namespace zFactoryPatternModified
{
    class Program
    {
        static void Main(string[] args)
        {
            // LAZY LOAD = on demand loading

            // case 0
            ActionFactory actionFactory = new ActionFactory();
            Console.WriteLine(Marshal.SizeOf(actionFactory));

            // case 1
            actionFactory.SalesAction.GetSales(); // only 1 obj
            Console.WriteLine(Marshal.SizeOf(actionFactory));

            // case 2
            actionFactory = new ActionFactory();
            actionFactory.EmployeeAction.GetEmployee();
            Console.WriteLine(Marshal.SizeOf(actionFactory));

            Console.ReadLine();
        }

        public static long GetSize(IActionFactory actionFactory)
        {
            using (Stream s = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(s, actionFactory);
                return s.Length;
            }
        }
    }
}
