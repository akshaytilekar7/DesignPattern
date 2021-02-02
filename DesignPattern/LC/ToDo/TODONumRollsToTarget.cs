using System;

namespace CSharp.Logic
{
    class TODONumRollsToTarget
    {

        /*
         *   var d = 30;
          var f = 30;
          var t = 500;
          var res = new Solution().NumRollsToTarget(d, f, t);
          Console.WriteLine(res);
         */

        public int[,,] t;
        public int NumRollsToTarget(int d, int f, int target)
        {
            int[] arr = new int[f];
            var sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
                sum += i + 1;
            }
            t = new int[f + 1, d + 1, target + 1];

            bool isEven = target % 2 == 0 || d == 1;
            var y = f * d; // max value from dice
            if (y < target)
                return 0;

            var res = Recursive(arr, arr.Length, d, target, isEven);
            Console.WriteLine(res);
            return Convert.ToInt32(res);
        }

        private int Recursive(int[] arr, int n, int cnt, int sum, bool isEven)
        {

            if (sum == 0)
                return isEven ? 1 : 2;

            if (cnt == 0)
                return 0;

            if (n <= 0 && sum > 0)
                return 0;

            if (t[n, cnt, sum] != 0)
                return t[n, cnt, sum];

            int a = 0;
            int b = 0;
            if (arr[n - 1] <= sum)
            {
                int r1 = Recursive(arr, n, cnt - 1, sum - arr[n - 1], isEven);
                int r2 = Recursive(arr, n - 1, cnt, sum, isEven);
                a = t[n, cnt, sum] = r1 + r2;
            }
            else
            {
                b = t[n, cnt, sum] = Recursive(arr, n - 1, cnt, sum, isEven);
            }

            return a + b;

        }
    }
}
