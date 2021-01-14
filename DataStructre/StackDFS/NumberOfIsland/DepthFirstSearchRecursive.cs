using System;

namespace DataStructure.StackDFS.NumberOfIsland
{
    public class DepthFirstSearchRecursive
    {
        public int NumIslands(int[,] grid)
        {
            if (grid == null || grid.Length == 0 || grid.GetLength(0) == 0)
                return 0;

            int islandCount = 0;
            var rows = grid.GetLength(0); ;
            var columns = grid.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    var current = grid[row, col];
                    if (current == 0)
                        continue;

                    RunDepthFirstSearch(grid, row, col, rows, columns);
                    islandCount++;
                }
            }

            return islandCount;
        }

        private static void RunDepthFirstSearch(int[,] grid, int row, int col, int rows, int columns)
        {
            if (!(row < rows && row >= 0 && col < columns && col >= 0))
                return;

            if (grid[row, col] == 1)
                return;

            grid[row, col] = 0;

            RunDepthFirstSearch(grid, row, col - 1, rows, columns);
            RunDepthFirstSearch(grid, row, col + 1, rows, columns);
            RunDepthFirstSearch(grid, row - 1, col, rows, columns);
            RunDepthFirstSearch(grid, row + 1, col, rows, columns);
        }

        public static void Main1(string[] args)
        {
            int[,] arr = {
                {1, 0, 1, 1, 0},
                {1, 1, 0, 1, 0},
                {0, 0, 0, 0, 1},
                {0, 0, 0, 0, 1},
                {0, 0, 0, 0, 1}
            };
            var d = new DepthFirstSearchRecursive().NumIslands(arr);
            Console.WriteLine("DepthFirstSearch : " + d);
            Console.ReadLine();
        }
    }
}
