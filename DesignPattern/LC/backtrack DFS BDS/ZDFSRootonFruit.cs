using System;

namespace CSharp
{
    public class Demo6
    {
        static void RF(int[,] arr, int currCol, int currRow, int[,] traversed, int day)
        {
            var col = arr.GetLength(0);
            var row = arr.GetLength(1);

            if (currCol < 0 || currCol >= col || currRow < 0 || currRow >= row)
                return;

            // Traversable and rot if not already rotten.
            // ALREADY VISITED OR EMPTY CELLS
            if (traversed[currCol, currRow] <= day || arr[currCol, currRow] == 0)
                return;

            // Update rot time.
            traversed[currCol, currRow] = day;

            // each line corresponding to 4 direction.
            RF(arr, currCol - 1, currRow, traversed, day + 1);
            RF(arr, currCol + 1, currRow, traversed, day + 1);
            RF(arr, currCol, currRow + 1, traversed, day + 1);
            RF(arr, currCol, currRow - 1, traversed, day + 1);
        }

        static int RottenFruit(int[,] arr)
        {
            var col = arr.GetLength(0);
            var row = arr.GetLength(1);

            #region set traversed to MAX value
            int[,] traversed = new int[col, row];
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    traversed[i, j] = int.MaxValue;
                }
            }
            #endregion

            #region if Rooten then ONLY call : RF(arr, i, j, traversed, 0);
            for (int i = 0; i < col - 1; i++)
            {
                for (int j = 0; j < row - 1; j++)
                {
                    if (arr[i, j] == 2) // 2 ROTTEN
                    {
                        RF(arr, i, j, traversed, 0);
                    }
                }
            }
            #endregion

            #region return -1 if contains fresh OR return max value from array
            int maxDay = 0;
            for (int i = 0; i < col - 1; i++)
            {
                for (int j = 0; j < row - 1; j++)
                {
                    if (arr[i, j] == 1) //Cells have fresh oranges
                    {
                        if (traversed[i, j] == int.MaxValue)
                            return -1;

                        if (maxDay < traversed[i, j])
                            maxDay = traversed[i, j];
                    }
                }
            }
            return maxDay;
            #endregion

        }

        public static void Main1(string[] args)
        {
            int[,] arr = new int[,]
            {
                {1, 0, 1, 1, 0},
                {2, 1, 0, 1, 0},
                {0, 0, 0, 2, 1},
                {0, 2, 0, 0, 1},
                {1, 1, 0, 0, 1}
            };
            Console.WriteLine(RottenFruit(arr));
        }

    }

}