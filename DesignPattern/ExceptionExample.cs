using DesignPattern.Partial;

namespace DesignPattern
{
    using System;

    namespace MyApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                Demo d = new Demo();

            }

            public static int Add()
            {
                try
                {

                }
                finally
                {
                    throw new DivideByZeroException();
                }
            }

            class Calculator
            {
                public int Divide(int number, int divisor)
                {
                    try
                    {
                        return number / divisor;
                    }
                    catch (DivideByZeroException ex)
                    {
                        //TODO: log error
                        Console.WriteLine("Can't divide by 0");
                        throw ex;//propage this error
                    }

                }
            }
        }
    }
}
