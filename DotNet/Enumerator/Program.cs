namespace Enumerator;

public class Program
{
    static void Main()
    {
        var fibonacci = new FibonacciSeries(10); // Generate first 10 Fibonacci numbers

        foreach (int number in fibonacci)
            Console.WriteLine(number);
    }
}


