using System;

namespace CSharp.Logic
{
    public class Lcs
    {
        private readonly int[,] _arr;

        public Lcs(int a = 4, int b = 4)
        {
            _arr = new int[a, b];
            for (int i = 0; i < _arr.GetLength(0); i++)
            {
                for (int j = 0; j < _arr.GetLength(1); j++)
                {
                    _arr[i, i] = -1;
                }
            }
        }
        public int CalculateLcs(string x, string y, int i, int j)
        {
            if (i == 0 || j == 0)
                return 0;

            if (x[i - 1] == y[j - 1])
                return 1 + CalculateLcs(x, y, i - 1, j - 1);

            return Math.Max(
                CalculateLcs(x, y, i - 1, j), CalculateLcs(x, y, i, j - 1)
            );
        }

        public string PrintLcs(string x, string y, int i, int j, string str)
        {
            if (i == 0 || j == 0)
                return str;

            if (x[i - 1] == y[j - 1])
            {
                str = str + x[i - 1];
                return PrintLcs(x, y, i - 1, j - 1, str);
            }

            var res1 = PrintLcs(x, y, i - 1, j, str);
            var res2 = PrintLcs(x, y, i, j - 1, str);


            if (res1.Length > res2.Length)
            {
                return res1;
            }

            return res2;
        }

        public int CalculateLcsMemo(string x, string y, int i, int j)
        {
            //not working

            if (i == 0 || j == 0)
                return 0;

            if (x[i - 1] == y[j - 1])
            {
                if (_arr[i - 1, j - 1] == -1)
                    _arr[i - 1, j - 1] = CalculateLcs(x, y, i - 1, j - 1);
                return 1 + _arr[i - 1, j - 1];
            }

            if (_arr[i - 1, j] == -1)
                _arr[i - 1, j] = CalculateLcsMemo(x, y, i - 1, j);

            if (_arr[i, j - 1] == -1)
                _arr[i, j - 1] = CalculateLcsMemo(x, y, i, j - 1);

            return Math.Max(_arr[i - 1, j], _arr[i, j - 1]);
        }

        public int CalculateLcSubString(string X, string Y, int i, int j, int count)
        {

            Console.WriteLine(
                new System.Diagnostics.StackTrace().ToString()
            );
            if (i == 0 || j == 0)
                return count;

            if (X[i - 1] == Y[j - 1])
                count = CalculateLcSubString(X, Y, i - 1, j - 1, count + 1);

            count = Math.Max(count,
                Math.Max(CalculateLcSubString(X, Y, i, j - 1, 0), CalculateLcSubString(X, Y, i - 1, j, 0)));

            return count;
        }
    }
}
