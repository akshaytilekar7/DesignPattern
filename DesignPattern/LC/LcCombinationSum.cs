using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    public class LcCombinationSum
    {
        //isSubsetSum(arr, n, sum) 
        static bool isSubsetSum(int[] arr, int n, int sum)
        {
            if (sum == 0)
                return true;

            if (n == 0)
                return false;

            if (arr[n - 1] > sum) // exclude
                return isSubsetSum(arr, n - 1, sum);

            return isSubsetSum(arr, n - 1, sum) || isSubsetSum(arr, n - 1, sum - arr[n - 1]);
        }


        public IList<IList<int>> Ans = new List<IList<int>>();

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            RecursiveDp(candidates, candidates.Length, target, new List<int>());
            return Ans;
        }

        public void RecursiveDp(int[] arr, int n, int sum, List<int> res)
        {
            if (sum == 0)
            {
                Ans.Add(res.ToList());
                return;
            }

            if (n <= 0 || sum <= 0)
                return;

            RecursiveDp(arr, n, sum - arr[n - 1], res.Append(arr[n - 1]).ToList());
            RecursiveDp(arr, n - 1, sum, res);
        }

        private void RecursiveBacktracking(int[] arr, int start, int sum, List<int> res)
        {
            if (sum < 0)
                return;

            if (sum == 0)
                Ans.Add(res.ToList());
            else
            {
                for (int i = start; i < arr.Length; i++)
                {
                    res.Add(arr[i]); // ADD LAST
                    RecursiveBacktracking(arr, i, sum - arr[i], res);
                    res.RemoveAt(res.Count - 1); // REMOVE LAST
                }
            }
        }

        public static void Main1(String[] args)
        {

            var arr = new int[] { 2, 3, 6, 7 };
            var sum = 7;
            var sol = new Solution();

            //sol.LcCombinationSum.CombinationSum(arr, sum);
            //Display(sol.LcCombinationSum.Ans);

            //sol.LcCombinationSum.Ans = new List<IList<int>>();
            //sol.LcCombinationSum.RecursiveBacktracking(arr, 0, sum, new List<int>());
            //Display(sol.LcCombinationSum.Ans);
            Console.ReadLine();
        }

        private static void Display(IList<IList<int>> res1)
        {
            foreach (var item in res1)
            {
                foreach (var item2 in item)
                {
                    Console.Write(item2 + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}