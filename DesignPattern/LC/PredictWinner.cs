using System;
using System.Linq;

namespace CSharp
{
    public class Solution
    {
        //https://leetcode.com/problems/predict-the-winner/
        //https://leetcode.com/problems/predict-the-winner/discuss/155217/Fro-Brute-Force-to-Top-down-DP
        public bool PredictTheWinner(int[] nums)
        {
            if (nums.Length == 0)
                return false;

            var res = Recursive(nums, 0, nums.Length - 1);
            var sum = nums.Sum();
            if (res > (sum / 2))
                return true;
            return false;
        }

        private int Recursive(int[] arr, int i, int j)
        {
            if (i == j)
                return arr[i];

            if (i > j)
                return 0;

            var m = arr[i];
            var r1 = m + Recursive(arr, i + 2, j);
            var r2 = m + Recursive(arr, i + 1, j - 1);

            var a1 = Math.Min(r1, r2);

            var n = arr[j];
            var r3 = n + Recursive(arr, i + 1, j - 1);
            var r4 = n + Recursive(arr, i, j - 2);

            var a2 = Math.Min(r3, r4);

            return Math.Max(a1, a2);

        }

        public static void Main(String[] args)
        {

            var arr = new int[] { 1, 5, 233, 7 };
            var x = new Solution().PredictTheWinner(arr);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }

}