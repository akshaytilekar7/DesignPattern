using System.Collections.Generic;
using System.Linq;

namespace CSharp.Logic
{
    public class TargetSum
    {
        public int Calculate(int[] arr, int ts)
        {
            List<int> v = new List<int>();
            foreach (int a in arr)
            {
                v.Add(a);
            }

            if (arr.Sum() < ts)
                return 0;

            return GetOld(arr, arr.Length, new int[0], 0, ts);
            //return Get(arr, 0, ts);
            //return CopyPasted(v, 0, ts);
        }

        private int Get(int[] arr, int i, int sum)
        {
            if (i >= arr.Length && sum != 0)
                return 0;

            if (sum == 0)
                return 1;

            return Get(arr, i + 1, sum) +
                   Get(arr, i + 1, sum - arr[i]) +
                   Get(arr, i + 1, sum + arr[i]);

        }

        static int CopyPasted(List<int> arr, int i, int sum)
        {
            if (i >= arr.Count && sum != 0)
                return 0;

            if (sum == 0)
                return 1;

            return CopyPasted(arr, i + 1, sum)
                   + CopyPasted(arr, i + 1, sum - arr[i])
                   + CopyPasted(arr, i + 1, sum + arr[i]);
        }
        private int GetOld(int[] arr, int n, int[] eval, int i, int ts)
        {

            var str = "";
            foreach (var item in eval)
            {
                str = str + item;
            }
            //Console.WriteLine(str);
            if (n == 0)
            {
                int res = 0;
                foreach (var item in eval)
                {
                    res = res + item;
                }

                if (res == ts)
                    return 1;
                return 0;
            }

            return GetOld(arr, n - 1, eval, i + 1, ts) +
                   GetOld(arr, n - 1, eval.Append(arr[n - 1]).ToArray(), i + 1, ts) +
                   GetOld(arr, n - 1, eval.Append(-arr[n - 1]).ToArray(), i + 1, ts);

        }

    }
}
