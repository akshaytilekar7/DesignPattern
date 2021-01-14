using System;

namespace DataStructure.StackDFS.LargestIsland
{
    public class BiggestIsland
    {
        private static int _row = 5;
        private static int _column = 5;
        private static bool[,] _visited = new bool[5, 5];

        public BiggestIsland(int r, int w)
        {
            _row = r;
            _column = w;
        }

        public int MaxAreaOfIsland(int[,] grid)
        {
            int numIslands = 0;
            int res = 0;

            for (int row = 0; row < grid.GetLength(0); ++row)
            {
                for (int col = 0; col < grid.GetLength(1); ++col)
                {
                    if (grid[row, col] == 1)
                        numIslands = DFS(grid, row, col);
                    if (numIslands > res)
                        res = numIslands;
                }
            }

            return res;
        }

        private int DFS(int[,] grid, int row, int col)
        {
            if (row < 0 ||
                col < 0 ||
                row > grid.GetLength(0) - 1 ||
                col > grid.GetLength(1) - 1 ||
                grid[row, col] == 0)
                return 0;

            grid[row, col] = 0;

            int val = DFS(grid, row + 1, col) +
                      DFS(grid, row - 1, col) +
                      DFS(grid, row, col + 1) +
                      DFS(grid, row, col - 1);

            return val + 1;
        }

        public static void Main1(String[] args)
        {
            int[,] graph = {

                { 1, 1, 0, 0, 0},
                { 0, 0, 0, 0, 1},
                { 1, 1, 0, 1, 1},
                { 0, 0, 0, 0, 0},
                { 1, 0, 1, 0, 1}
            };
            var obj = new BiggestIsland(graph.GetLength(0), graph.GetLength(1)).MaxAreaOfIsland(graph);
            Console.WriteLine("MaxAreaOfIsland " + obj);
        }

    }
}
