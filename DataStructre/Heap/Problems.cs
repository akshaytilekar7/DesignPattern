using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure.Heap
{
    class Problems
    {
        public int FindKthLargest(int[] arr, int k)
        {
            SortedList<int, int> heap = new SortedList<int, int>();
            foreach (var t in arr)
            {
                if (heap.ContainsKey(-1 * t))
                    heap.Remove(heap.First(x => x.Key == -1 * t).Key);

                heap.Add(-1 * t, -1 * t);
                if (heap.Count > k) heap.Remove(heap.LastOrDefault().Key);
            }

            return heap.Last().Key * -1;
        }

        public int FindKthLargest1(int[] arr, int k)
        {
            List<int> heap = new List<int>();
            foreach (var t in arr)
            {
                heap.Add(t);
                heap = heap.OrderByDescending(x => x).ToList();
                if (heap.Count > k) heap.Remove(heap.Last());
            }

            return heap.Last();
        }


        public static void Main1(string[] args)
        {
            var arr = new int[] { 3, 2, 1, 5, 6, 4 };
            var k = 3;
            var data = new Problems().FindKthLargest(arr, k);
            Console.WriteLine(data);

        }
    }
}