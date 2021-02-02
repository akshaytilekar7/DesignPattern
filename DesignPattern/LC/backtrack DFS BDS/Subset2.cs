using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    //https://leetcode.com/problems/subsets-ii/description/
    //https://medium.com/leetcode-patterns/leetcode-pattern-3-backtracking-5d9e5a03dc26
    public class Demo3
    {
        List<int> subset = new List<int>();

        void Subset2(int[] nums, int start)
        {
            //nums.Sort(); // make it sorted  1
            Print(subset);
            for (int i = start; i < nums.Count(); i++)
            {
                if (i > start && nums[i] == nums[i - 1]) continue;  // 2  skip over duplicates

                subset.Add(nums[i]);
                Subset2(nums, i + 1);
                subset.Remove(nums[i]);
            }
        }
        private void Print(List<int> subset)
        {
            foreach (var item in subset)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static void Main1(string[] args)
        {
            Demo d = new Demo();
            int[] n = new int[] { 1, 2, 3 };
            //d.Subset2(n, 0);
            Console.WriteLine();
        }
    }

}