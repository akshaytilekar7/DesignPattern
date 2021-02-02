using System;
//https://leetcode.com/problems/integer-break/
namespace CSharp.Logic
{
    public class IntegerBreak
    {
        private int[,] _t;

        public int GetIntegerBreak(int n)
        {
            int[] arr = new int[n - 1];
            for (int i = 0; i < n - 1; i++)
                arr[i] = i + 1;

            _t = new int[n + 1, n + 1];
            return RecursiveTopDown(arr, arr.Length, n);
        }
        private int RecursiveTopDown(int[] arr, int n, int sum)
        {
            if (sum == 0)
                return 1;

            if (n == 0)
                return 1;

            if (_t[n, sum] != 0)
            {
                return _t[n, sum];
            }

            int a = 0, b = 0;
            if (arr[n - 1] <= sum)
            {
                var rr1 = arr[n - 1] * RecursiveTopDown(arr, n, sum - arr[n - 1]);
                var rr2 = RecursiveTopDown(arr, n - 1, sum);
                a = _t[n, sum] = Math.Max(rr1, rr2);
            }
            else
            {
                b = _t[n, sum] = RecursiveTopDown(arr, n - 1, sum);
            }

            return Math.Max(a, b);
        }

        private int Recursive(int[] arr, int n, int sum)
        {
            if (sum == 0)
                return 1;

            if (n == 0)
                return 1;

            int a = 0, b = 0;
            if (arr[n - 1] <= sum)
            {
                var rr1 = arr[n - 1] * Recursive(arr, n, sum - arr[n - 1]);
                var rr2 = Recursive(arr, n - 1, sum);
                a = Math.Max(rr1, rr2);
            }
            else
            {
                b = Recursive(arr, n - 1, sum);
            }

            return Math.Max(a, b);
        }


    }
}
