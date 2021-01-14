using System;

namespace DataStructure.QueueBFS.RottenFruit
{
    public class RottenFruitRecursive
    {
        static void Rf(int[,] arr, int curCol, int curRow, int[,] traversed, int day)
        {
            var col = arr.GetLength(0);
            var row = arr.GetLength(1);

            if (curCol < 0 || curCol >= col || curRow < 0 || curRow >= row)
                return;

            // Traverse able and rot if not already rotten.
            // ALREADY VISITED OR EMPTY CELLS
            if (traversed[curCol, curRow] <= day || arr[curCol, curRow] == 0)
                return;

            // Update rot time.
            traversed[curCol, curRow] = day;

            // each line corresponding to 4 direction.
            Rf(arr, curCol - 1, curRow, traversed, day + 1);
            Rf(arr, curCol + 1, curRow, traversed, day + 1);
            Rf(arr, curCol, curRow + 1, traversed, day + 1);
            Rf(arr, curCol, curRow - 1, traversed, day + 1);
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
                        Rf(arr, i, j, traversed, 0);
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