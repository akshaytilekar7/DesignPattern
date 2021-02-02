using System;
using System.Collections.Generic;

namespace DesignPattern.LC
{
    public class Lc
    {
        private readonly Dictionary<string, int> dic = new Dictionary<string, int>();

        public int MaxScore(int[] cardPoints, int k)
        {
            return Recursive(cardPoints, 0, cardPoints.Length - 1, k, 0);
        }
        private int Recursive(int[] arr, int si, int ei, int k, int pt)
        {
            if (k == 0)
                return pt;

            if ((si < 0 || si >= arr.Length) && k != 0)
                return 0;

            if ((ei < 0 || ei > arr.Length) && k != 0)
                return 0;

            var leftSide = Recursive(arr, si + 1, ei, k - 1, pt + arr[si]);
            var rightSide = Recursive(arr, si, ei - 1, k - 1, pt + arr[ei]);
            return Math.Max(leftSide, rightSide);
        }

        /// <summary>
        /// NOT WORKING 
        /// </summary>
        private int RecursiveTopDOwn(int[] arr, int si, int ei, int k, int pt)
        {
            String key = si + "_" + ei;

            if (k == 0)
                return pt;

            if (si > ei) { return pt; }

            if (dic.ContainsKey(key))
            {
                dic.TryGetValue(key, out var x);
                return x;
            }

            var leftSide = RecursiveTopDOwn(arr, si + 1, ei, k - 1, pt + arr[si]);
            var rightSide = RecursiveTopDOwn(arr, si, ei - 1, k - 1, pt + arr[ei]);

            var res = Math.Max(leftSide, rightSide);
            dic.Add(key, res);
            return res;
        }

    }
}