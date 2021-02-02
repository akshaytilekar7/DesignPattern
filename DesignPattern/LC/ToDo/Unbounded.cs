namespace CSharp.Logic
{
    public class Unbounded
    {
        public int CountOfCoinChange(int[] arr, int n, int sum)
        {
            if (sum == 0)
                return 1;

            if (n == 0 && sum != 0)
                return 0;

            if (sum <= 0 && n != 0)
                return 0;

            return CountOfCoinChange(arr, n - 1, sum) +
                   CountOfCoinChange(arr, n, sum - arr[n - 1]);

        }
    }
}
