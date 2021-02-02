using System;
using System.Collections.Generic;

namespace DesignPattern.LC.backtrack_DFS_BDS
{
    //https://leetcode.com/problems/sliding-window-maximum/submissions/
    public class Demo2
    {
        public static void maxSlidingWindows(int[] arr, int size, int k)
        {
            LinkedList<int> ll = new LinkedList<int>();
            for (int i = 0; i < size; i++)
            {
                // Remove out of range elements
                // i - k always gives starting index of window. remove unwanted index
                if (ll.Count > 0 && ll.First.Value <= i - k)
                    ll.RemoveFirst();


                // Remove smaller values at left.
                while (ll.Count > 0 && arr[ll.Last.Value] <= arr[i])
                    ll.RemoveLast();

                ll.AddLast(i);

                // Largest value in window of size k is at index que[0]
                // It is displayed to the screen.
                if (i >= (k - 1))
                    Console.WriteLine(arr[ll.First.Value]);
            }
        }

        /*
        1st if - to remove values as we goes on right side
               - imagine we have to remove 1 ele from start as we reach sliding window of size k unit completes
        */


        public int[] maxSlidingWindow1s(int[] arr, int size, int k)
        {
            List<int> ls = new List<int>();
            LinkedList<int> ll = new LinkedList<int>();
            for (int i = 0; i < size; i++)
            {
                if (ll.Count > 0 && (i % k) == 0)
                    ll.RemoveFirst();


                // Remove smaller values at left.
                while (ll.Count > 0 && arr[ll.Last.Value] <= arr[i])
                    ll.RemoveLast();

                ll.AddLast(i);

                // Largest value in window of size k is at index que[0]
                // It is displayed to the screen.
                if (i >= (k - 1))
                    ls.Add(arr[ll.First.Value]);
            }
            return ls.ToArray();
        }

        public static void Main1(string[] args)
        {
            int[] arr = new int[] { 11, 2, 75, 92, 59, 90, 55 };
            int k = 3;
            maxSlidingWindows(arr, 7, 3);
        }
    }

}