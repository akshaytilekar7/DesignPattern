using System;
using System.Linq;

namespace CSharp.Logic
{
    public class EqualSumPartition
    {
        public bool CanPossible(int[] arr, int length, int sum)
        {

            if (arr.Sum() % 2 != 0)
                return false;

            return RecursiveEqualSumPartition(arr, length, sum / 2);
        }

        public bool RecursiveEqualSumPartition(int[] arr, int length, int sum)
        {
            if (sum == 0)
                return true;

            if (length == 0 && sum != 0)
                return false;

            if (sum < arr[length - 1])
                return RecursiveEqualSumPartition(arr, length - 1, sum);

            return RecursiveEqualSumPartition(arr, length - 1, sum - arr[length - 1]) ||
                   RecursiveEqualSumPartition(arr, length - 1, sum);

        }

        public int RecursiveEqualSumPartition1(int[] arr, int length, int sum)
        {
            if (sum == 0)
                return 0;

            if (length == 0 && sum != 0)
                return 0;

            if (sum < arr[length - 1])
                return RecursiveEqualSumPartition1(arr, length - 1, sum);

            return Math.Min(RecursiveEqualSumPartition1(arr, length - 1, sum - arr[length - 1]),
                   RecursiveEqualSumPartition1(arr, length - 1, sum));

        }
    }
}
