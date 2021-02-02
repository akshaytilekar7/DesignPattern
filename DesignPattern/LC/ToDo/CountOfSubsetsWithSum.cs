namespace CSharp.Logic
{
    class SubsetsWithSum
    {
        int backtrackCount = 0;
        public bool IsPossible(int[] arr, int sum)
        {
            return TopDown(arr, arr.Length, sum);
        }

        private bool Recursive(int[] arr, int n, int sum)
        {
            if (sum == 0)
                return true;

            if (sum != 0 && n == 0)
                return false;

            if (arr[n - 1] <= sum)
            {
                return Recursive(arr, n - 1, sum - arr[n - 1]) || Recursive(arr, n - 1, sum);
            }
            else
            {
                return Recursive(arr, n - 1, sum);
            }
        }

        private bool TopDown(int[] arr, int n, int sum)
        {
            bool[,] t = new bool[n + 1, sum + 1];

            for (int i = 0; i < sum + 1; i++)
            {
                t[0, i] = false;
            }
            for (int i = 0; i < n + 1; i++)
            {
                t[i, 0] = true;
            }

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < sum + 1; j++)
                {

                    if (arr[i - 1] <= j)   // IMP
                    {
                        t[i, j] = t[i - 1, j - arr[i - 1]] || t[i - 1, j];
                    }
                    else
                    {
                        t[i, j] = t[i - 1, j];
                    }
                }
            }
            return t[n, sum];
        }
    }
}
