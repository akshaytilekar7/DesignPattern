using System;

namespace DesignPattern.LC.backtrack_DFS_BDS
{
    public class Demo1
    {
        public static void Calculate(int[,] arr, int currCol, int currRow, int[,] traversed, int dist)
        {
            int maxRow = arr.GetLength(0);
            int maxCol = arr.GetLength(1);

            // Range check
            if (currCol < 0 || currCol >= maxCol || currRow < 0 || currRow >= maxRow)
                return;

            // Traversable if their is a better distance.
            if (traversed[currCol, currRow] <= dist)
                return;

            // Update distance.
            traversed[currCol, currRow] = dist;

            // each line corresponding to 4 direction.
            Calculate(arr, currCol - 1, currRow, traversed, dist + 1);
            Calculate(arr, currCol + 1, currRow, traversed, dist + 1);
            Calculate(arr, currCol, currRow + 1, traversed, dist + 1);
            Calculate(arr, currCol, currRow - 1, traversed, dist + 1);
        }
        public static void DistNearestFill(int[,] arr)
        {
            int col = arr.GetLength(0);
            int row = arr.GetLength(1);
            int[,] traversed = new int[col, row];

            for (int i = 0; i < col; i++)
                for (int j = 0; j < row; j++)
                    traversed[i, j] = int.MaxValue;

            for (int i = 0; i < col; i++)
                for (int j = 0; j < row; j++)
                    if (arr[i, j] == 1)
                        Calculate(arr, i, j, traversed, 0);

            Print(col, row, traversed);
        }
        private static void Print(int col, int row, int[,] traversed)
        {
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                    Console.Write(" " + traversed[i, j]);
                Console.WriteLine();
            }
        }
        public static void Main1(string[] args)
        {
            int[,] arr = new int[,]
            {
                {1, 0, 1, 1, 0},
                {1, 1, 0, 1, 0},
                {0, 0, 0, 0, 1},
                {0, 0, 0, 0, 1},
                {0, 0, 0, 0, 1}
            };
            DistNearestFill(arr);
        }

    }

}