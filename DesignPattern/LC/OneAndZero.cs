using System;
using System.Linq;

namespace CSharp.OLD
{
    //https://leetcode.com/problems/ones-and-zeroes/
    class OneAndZero
    {
        private int[,,] dp;
        public int FindMaxForm(string[] strs, int m, int n)
        {
            dp = new int[m + 1, n + 1, strs.Length + 1];
            var res1 = RecursiveMaxTopDown(strs, m, n, strs.Length);
            dp = new int[m + 1, n + 1, strs.Length + 1];
            var res2 = RecursiveWithParaPts(strs, m, n, strs.Length, 0);
            dp = new int[m + 1, n + 1, strs.Length + 1];
            var res3 = RecursiveMax(strs, m, n, strs.Length);
            dp = new int[m + 1, n + 1, strs.Length + 1];
            var res4 = RecursiveMaxTopDown2(strs, m, n, strs.Length, 0);

            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            Console.WriteLine(res4);


            return res1;
        }
        private int RecursiveWithParaPts(string[] arr, int m, int n, int len, int pts)
        {
            if (len <= 0 || (m <= 0 && n <= 0))
                return pts;

            var cntZeroes = arr[len - 1].Count(x => x == '0');
            var cntOnes = arr[len - 1].Count(x => x == '1');

            var r1 = 0;
            var r2 = 0;

            if (cntZeroes <= m && cntOnes <= n)
            {
                var t1 = RecursiveWithParaPts(arr, m - cntZeroes, n - cntOnes, len - 1, pts + 1);
                var t2 = RecursiveWithParaPts(arr, m, n, len - 1, pts);
                r1 = Math.Max(t1, t2);
            }
            else
            {
                r2 = RecursiveWithParaPts(arr, m, n, len - 1, pts);
            }

            return Math.Max(r1, r2);

        }
        private int RecursiveMax(string[] arr, int m, int n, int len)
        {
            if (len <= 0 || (m <= 0 && n <= 0))
                return 0;

            var cntZeroes = arr[len - 1].Count(x => x == '0');
            var cntOnes = arr[len - 1].Count(x => x == '1');

            var r1 = 0;
            var r2 = 0;

            if (cntZeroes <= m && cntOnes <= n)
            {
                var t1 = 1 + RecursiveMax(arr, m - cntZeroes, n - cntOnes, len - 1);
                var t2 = RecursiveMax(arr, m, n, len - 1);
                r1 = Math.Max(t1, t2);
            }
            else
            {
                r2 = RecursiveMax(arr, m, n, len - 1);
            }

            return Math.Max(r1, r2);

        }
        private int RecursiveMaxTopDown(string[] arr, int m, int n, int len)
        {
            if (len <= 0 || (m <= 0 && n <= 0))
                return 0;

            if (dp[m, n, len] != 0)
                return dp[m, n, len];

            var cntZeroes = arr[len - 1].Count(x => x == '0');
            var cntOnes = arr[len - 1].Count(x => x == '1');

            var r1 = 0;
            var r2 = 0;

            if (cntZeroes <= m && cntOnes <= n)
            {
                var t1 = 1 + RecursiveMaxTopDown(arr, m - cntZeroes, n - cntOnes, len - 1);
                var t2 = RecursiveMaxTopDown(arr, m, n, len - 1);
                r1 = dp[m, n, len] = Math.Max(t1, t2);
            }
            else
            {
                r2 = dp[m, n, len] = RecursiveMaxTopDown(arr, m, n, len - 1);
            }

            return Math.Max(r1, r2);

        }
        private int RecursiveMaxTopDown2(string[] arr, int m, int n, int len, int pts)
        {
            if (len <= 0 || (m <= 0 && n <= 0))

                return pts;

            if (dp[m, n, len] != 0)
                return dp[m, n, len];

            var cntZeroes = arr[len - 1].Count(x => x == '0');
            var cntOnes = arr[len - 1].Count(x => x == '1');

            var r1 = 0;
            var r2 = 0;

            if (cntZeroes <= m && cntOnes <= n)
            {
                var t1 = RecursiveMaxTopDown2(arr, m - cntZeroes, n - cntOnes, len - 1, pts + 1);
                var t2 = RecursiveMaxTopDown2(arr, m, n, len - 1, pts);
                r1 = dp[m, n, len] = Math.Max(t1, t2);
            }
            else
            {
                r2 = dp[m, n, len] = RecursiveMaxTopDown2(arr, m, n, len - 1, pts);
            }

            return dp[m, n, len] = Math.Max(r1, r2);

        }
    }
}
