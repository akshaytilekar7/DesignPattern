using System.Linq;

namespace CSharp.Logic
{
    public class SubsetSum
    {
        public bool CanPossible(int[] arr, int length, int sum)
        {

            if (sum == 0)
                return true;

            if (length == 0 && sum != 0)
                return false;

            if (arr[length - 1] > sum)
                return CanPossible(arr, length - 1, sum);

            return CanPossible(arr, length - 1, sum - arr[length - 1])
                    || CanPossible(arr, length - 1, sum);

        }

        public int CountOfSubsetsWithSumGet(int[] arr, int n, int sum)
        {
            if (sum == 0)
                return 1;

            if (sum != 0 && n == 0)
                return 0;

            if (sum > arr.Sum())
                return 0;

            return CountOfSubsetsWithSumGet(arr, n - 1, sum) + (CountOfSubsetsWithSumGet(arr, n - 1, sum - arr[n - 1]));

        }

    }
}
