using System;

namespace CSharp.Logic
{
    public class MCM
    {
        int[,] t;
        public void calculate()
        {
            var arr = new int[] { 10, 20, 30, 40, 30 };
            t = new int[arr.Length + 1, arr.Length + 1];

            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            var r1 = RecursiveTopDown(arr, 1, arr.Length - 1);
            Console.WriteLine(r1);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

            watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            var r2 = Recursive(arr, 1, arr.Length - 1);
            Console.WriteLine(r2);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

        }

        private int Recursive(int[] arr, int i, int j)
        {
            if (i >= j)
                return 0;

            var min = int.MaxValue;
            for (int k = i; k <= j - 1; k++)
            {
                var temp = Recursive(arr, i, k) +
                           Recursive(arr, k + 1, j) +
                           (arr[i - 1] * arr[k] * arr[j]);
                if (temp < min)
                    min = temp;
            }

            return min;
        }

        private int RecursiveTopDown(int[] arr, int i, int j)
        {
            if (i >= j)
                return 0;

            var min = int.MaxValue;
            if (t[i, j] != 0)
                return t[i, j];

            for (int k = i; k <= j - 1; k++)
            {
                var temp = t[i, j] = RecursiveTopDown(arr, i, k) +
                           RecursiveTopDown(arr, k + 1, j) +
                           (arr[i - 1] * arr[k] * arr[j]);
                if (temp < min)
                    min = temp;
            }

            return min;
        }
    }
}
