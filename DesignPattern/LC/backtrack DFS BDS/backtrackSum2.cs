using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    //https://leetcode.com/problems/combination-sum-ii/description/
    //https://medium.com/leetcode-patterns/leetcode-pattern-3-backtracking-5d9e5a03dc26
    public class Demo
    {
        List<int> combination = new List<int>();
        List<List<int>> combinations = new List<List<int>>();
        List<List<int>> combinationSum(List<int> candidates, int target)
        {
            //sort(candidates.begin(), candidates.end());
            explore(candidates, 0, target);
            return combinations;
        }

        void explore(List<int> candidates, int start, int target)
        {
            if (target == 0)
            {
                Print(combination); // yes! a valid solution found
                return;
            }
            if (target < 0) return; // this is when we lose hope and backtrack :(

            for (int i = start; i < candidates.Count; i++)
            {
                if (i > start && candidates[i] == candidates[i - 1]) continue; // skip duplicates

                combination.Add(candidates[i]);  // explore all solutions using candidates[i] at least once
                explore(candidates, i, target - candidates[i]);
                combination.Remove(candidates[i]); // explore solutions that don't use candidates[i]
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
            var x = d.combinationSum(n.ToList(), 2);
            Console.WriteLine();
        }
    }

}