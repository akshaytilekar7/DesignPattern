using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    public class GetMaxArea2Histogram
    {
        public static int GetMaxArea2(int[] arr)
        {
            Stack<int> stk = new Stack<int>();
            int maxArea = 0, i = 0;

            while (i < arr.Length)
            {
                // stack always push in index in increasing order
                // coz if POP is less then only e are adding to stack
                while (i < arr.Length && (stk.IsEmpty() || stk.IsTopLess(arr, arr[i]))) // stackEmpty asla tr no need to check isTopLess
                {
                    stk.Push(i);
                    i++;
                }
                //i == arr.Length ?

                while (stk.Count > 0 && (i == arr.Length || stk.IsTopGreaterOrEqual(arr, arr[i])))
                {
                    var top = stk.Peek();
                    stk.Pop();
                    var topArea = arr[top] * (stk.Count == 0 ? i : i - stk.Peek() - 1);
                    if (maxArea < topArea)
                        maxArea = topArea;
                }
            }
            return maxArea;
        }
        public static void Main123(string[] args)
        {
            int[] arr = new int[] { 7, 6, 5, 4 };
            int size = arr.Length;
            int value = GetMaxArea2(arr);
            Console.WriteLine("GetMaxArea :: " + value);
        }


    }

    public static class Ext
    {
        public static bool IsEmpty(this Stack<int> s)
        {
            return !s.Any();
        }

        public static bool IsNotEmpty(this Stack<int> s)
        {
            return s.Any();
        }

        public static bool IsTopGreaterOrEqual(this Stack<int> s, int[] arr, int val)
        {
            return arr[s.Peek()] >= val;
        }
        public static bool IsTopLess(this Stack<int> s, int[] arr, int val)
        {
            return !s.IsTopGreaterOrEqual(arr, val);
        }
    }
}