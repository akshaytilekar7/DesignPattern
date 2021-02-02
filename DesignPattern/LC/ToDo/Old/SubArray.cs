using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.OLD
{
    class SubArray1
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        public int MaxSubarraySumCircularOld(int[] arr)
        {
            if (arr.Length == 1)
                return arr[0];

            if (arr.Length == 2)
                return Math.Max(arr[0], arr[1]);

            var normalSum = KA(arr);
            var max = Int32.MinValue;

            for (int i = 1; i < arr.Length; i++)
            {
                int[] insertAtLast = arr.Take(i).ToArray();
                int[] temp = arr.Skip(i).Take(arr.Length - i).ToArray();
                var ls = temp.ToList();
                ls.AddRange(insertAtLast.ToList());

                temp = ls.ToArray();
                var k = GetKey(temp);
                var ans = dic.ContainsKey(k) ? dic[k] : KA(temp);
                if (max < ans)
                    max = ans;
            }
            return Math.Max(max, normalSum);
        }

        public int MaxSubarraySumCircular(int[] arr)
        {
            if (arr.Length == 1)
                return arr[0];

            if (arr.Length == 2)
                return Math.Max(arr[0], arr[1]);
            var sumOfArray = arr.Sum();
            var nonCircularSum = KA(arr);

            for (int i = 0; i < arr.Length; i++)
                arr[i] = -arr[i];

            int circularSum = sumOfArray + KA(arr);

            if (circularSum == 0)
                return nonCircularSum;
            return Math.Max(circularSum, nonCircularSum);
        }

        private int KA(int[] a)
        {
            int ms = a[0];
            int gs = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                ms = Math.Max(a[i], ms + a[i]);
                if (ms > gs)
                    gs = ms;

            }
            return gs;
        }

        private void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "\t");
            }
            Console.WriteLine();

        }
        private string GetKey(int[] a)
        {
            var strDp = string.Empty;
            for (int i = 0; i < a.Length; i++)
                strDp += a[i];

            return strDp;

        }
    }
}
