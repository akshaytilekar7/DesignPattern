using System;

namespace DataStructure.StackDFS.NumberOfIsland
{
    public class NumberOfIslandRecursive
    {
        public int NumIslands(int[,] grid)
        {
            var n = grid.GetLength(0);
            var m = grid.GetLength(1);
            int c = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (grid[i, j] == 1)
                    {
                        VisitIsland(grid, i, j);
                        c++;
                    }

            return c;
        }

        private void VisitIsland(int[,] grid, int i, int j)
        {
            var n = grid.GetLength(0);
            var m = grid.GetLength(1);
            if (i < 0 || j < 0 || i >= n || j >= m || grid[i, j] == 0) return;

            grid[i, j] = 0;

            VisitIsland(grid, i, j + 1);
            VisitIsland(grid, i + 1, j);
            VisitIsland(grid, i, j - 1);
            VisitIsland(grid, i - 1, j);
        }

        public static void Main1(string[] args)
        {
            int[,] arr = {
                {1, 0, 1, 1, 0},
                {1, 0, 0, 1, 0},
                {0, 1, 1, 1, 1},
                {0, 1, 0, 0, 0},
                {1, 1, 0, 0, 1}
            };
            var d = new NumberOfIslandRecursive().NumIslands(arr);
            Console.WriteLine("NumberOfIslandRecursive : " + d);
            Console.ReadLine();
        }
    }
}
