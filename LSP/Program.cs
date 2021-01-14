//Subtypes must be substitutable for their base types.
//Functions that use pointers or references to base classes must be able to use objects
//of derived classes without knowing it

using LSP.ByInheritance;
using System;

namespace LSP
{
    class Program
    {
        static void GetAreaTest(Rectangle r)
        {

            Console.WriteLine("Expected area of " + ("") + ", got " + r.GetArea());
        }
        static void Main(string[] args)
        {
            #region ByInheritace

            Rectangle rc = new Rectangle();
            rc.SetHeight(2);
            rc.SetWidth(3);
            GetAreaTest(rc);

            Rectangle sq = new Square();
            sq.SetWidth(3);
            GetAreaTest(sq);

            Console.ReadLine();

            #endregion

            #region Models

            /*
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };
            SumCalculator sum = new SumCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");

            EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");


            // as we say parent can easily replaceable with child (but hear it CANT)

            SumCalculator evenSum2 = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum2.Calculate()}");

            // op will 40 invalid
            // so add virtual override 
            // but again same problem  : parent canT easily replaceable with child

            Console.WriteLine("SOL :");
            Calculator sum1 = new SumCalculator1(numbers);
            Console.WriteLine($"The sum of all the numbers: {sum1.Calculate()}");
            Calculator evenSum1 = new EvenNumbersSumCalculator1(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum1.Calculate()}");
            */

            #endregion
        }
    }
}
