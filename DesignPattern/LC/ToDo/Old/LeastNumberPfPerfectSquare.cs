using System;
using System.Collections.Generic;
//https://leetcode.com/problems/perfect-squares/
namespace CSharp.OLD
{
    public class LeastNumberPfPerfectSquare1
    {
        int[,] t;
        public void NumSquares()
        {
            int sum = 94;
            var lst = new List<int>() { 2, 3, 5 }.ToArray();
            var watch = new System.Diagnostics.Stopwatch();

            watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Console.WriteLine(Recursive(lst, lst.Length, sum, 0));
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

            watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Console.WriteLine(RecursiveNewWorking(lst, lst.Length, sum));
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

            t = new int[lst.Length + 1, sum + 1];
            watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Console.WriteLine(RecursiveBottomUp(lst, lst.Length, sum));
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
        private int Recursive(int[] arr, int n, int sum, int count)
        {
            if (sum == 0)
                return count;

            if (n <= 0 && sum >= 1)
                return 0;

            if (sum < 0)
                return 0;
            int aa = 0, bb = 0;
            if (arr[n - 1] <= sum)
            {
                int a = Recursive(arr, n, sum - arr[n - 1], count + 1);
                int b = Recursive(arr, n - 1, sum, count);
                if (a == 0)
                    aa = b;
                else if (b == 0)
                    aa = a;
                else
                    aa = Math.Min(a, b);
            }
            else
            {
                bb = Recursive(arr, n - 1, sum, count);
            }
            if (aa == 0)
                return bb;
            if (bb == 0)
                return aa;
            return Math.Min(aa, bb);

        }

        private int RecursiveNewWorking(int[] arr, int n, int sum)
        {
            if (sum == 0)
                return 0;

            if (n <= 0 && sum >= 1)
                return int.MaxValue - 1;

            if (sum < 0)
                return int.MaxValue - 1;

            int aa = 0, bb = 0;
            if (arr[n - 1] <= sum)
            {
                int a = 1 + RecursiveNewWorking(arr, n, sum - arr[n - 1]);
                int b = RecursiveNewWorking(arr, n - 1, sum);
                aa = Math.Min(a, b);
            }
            else
            {
                bb = RecursiveNewWorking(arr, n - 1, sum);
            }
            if (aa == 0)
                return bb;
            if (bb == 0)
                return aa;
            return Math.Min(aa, bb);

        }

        private int RecursiveNewWorkingMemo(int[] arr, int n, int sum)
        {
            if (sum == 0)
                return 0;

            if (n <= 0 && sum >= 1)
                return int.MaxValue - 1;

            if (sum < 0)
                return int.MaxValue - 1;

            if (t[n, sum] != 0)
            {
                return t[n, sum];
            }
            int aa = 0, bb = 0;
            if (arr[n - 1] <= sum)
            {
                int a = 1 + RecursiveNewWorkingMemo(arr, n, sum - arr[n - 1]);
                int b = RecursiveNewWorkingMemo(arr, n - 1, sum);
                aa = t[n, sum] = Math.Min(a, b);
            }
            else
            {
                bb = t[n, sum] = RecursiveNewWorkingMemo(arr, n - 1, sum);
            }
            if (aa == 0)
                return bb;
            if (bb == 0)
                return aa;
            return Math.Min(aa, bb);

        }

        private int RecursiveBottomUp(int[] arr, int n, int sum)
        {
            var max = 50000; //int.MaxValue - 1
            if (sum == 0)
                return 0;   // 1st columns

            if (n <= 0 && sum >= 1)
                return max; //1st row 

            if (sum < 0)
                return max;

            if (t[n, sum] != 0)
            {
                return t[n, sum];
            }
            int r1 = 0, r2 = 0;
            if (arr[n - 1] <= sum)
            {
                var f = 1 + RecursiveBottomUp(arr, n, sum - arr[n - 1]);
                var g = RecursiveBottomUp(arr, n - 1, sum);
                r1 = t[n, sum] = Math.Min(f, g);
            }
            else
            {
                r2 = t[n, sum] = RecursiveBottomUp(arr, n - 1, sum);
            }

            if (r1 == 0)
                return r2;
            if (r2 == 0)
                return r1;
            return Math.Min(r1, r2);

        }

        private int TopDown(int[] arr, int n, int sum, int count)
        {
            int[,] t = new int[n + 1, sum + 1];

            for (int i = 0; i < n + 1; i++)
            {
                t[i, 0] = 1;
            }
            for (int i = 0; i < sum + 1; i++)
            {
                t[0, i] = 0;
            }
            int aa = 0, bb = 0;
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < sum + 1; j++)
                {

                    if (arr[i - 1] <= j)
                    {
                        int a = t[i, j - arr[i - 1]];
                        int b = t[i - 1, j];
                        if (a == 0)
                            aa = b;
                        else if (b == 0)
                            aa = a;
                        else
                            aa = Math.Min(a, b);

                        t[i, j] = aa;
                    }
                    else
                    {
                        t[i, j] = t[i - 1, j];
                    }
                }
            }

            Print(t);
            return t[n, sum];
        }

        private int[] ListPerfectSquare(int number)
        {
            List<int> res = new List<int>();

            for (int i = 0; i <= number; i++)
            {
                if (IsPerfectSquare(i))
                    res.Add(i);
            }

            return res.ToArray();

        }
        private bool IsPerfectSquare(int n)
        {
            for (int i = 1; i * i <= n; i++)
            {
                if ((n % i == 0) && (n / i == i))
                {
                    return true;
                }
            }
            return false;
        }

        private void Print(int[,] t)
        {
            Console.Clear();
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    if (t[i, j] == -1)
                        Console.Write(i + "" + j + "\t");
                    else
                        Console.Write(i + "" + j + "[" + t[i, j] + "]" + "\t");

                }
                Console.WriteLine();
            }
        }

    }
}

