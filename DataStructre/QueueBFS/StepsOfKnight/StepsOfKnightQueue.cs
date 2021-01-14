using System;
using System.Collections.Generic;

namespace DataStructure.QueueBFS.StepsOfKnight
{
    public class StepsOfKnightRecursive1
    {
        public class Cell
        {
            public int X, Y;
            public int Dis;

            public Cell(int x, int y, int dis)
            {
                X = x;
                Y = y;
                Dis = dis;
            }
        }

        static bool IsInside(int x, int y, int n)
        {
            return (x >= 1 && x <= n && y >= 1 && y <= n);
        }

        static int MinStepToReachTarget(int[] knightPos, int[] targetPos, int n)
        {
            int[] dx = { -2, -1, 1, 2, -2, -1, 1, 2 };
            int[] dy = { -1, -2, -2, -1, 1, 2, 2, 1 };

            Queue<Cell> q = new Queue<Cell>();

            q.Enqueue(new Cell(knightPos[0], knightPos[1], 0));

            bool[,] visit = new bool[n + 1, n + 1];

            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    visit[i, j] = false;

            // visit starting state 
            visit[knightPos[0], knightPos[1]] = true;

            // loop until we have one element in queue 
            while (q.Count != 0)
            {
                var t = q.Peek();
                q.Dequeue();

                // if current cell is equal to target cell, 
                // return its distance 
                if (t.X == targetPos[0] && t.Y == targetPos[1])
                    return t.Dis;

                // loop for all reachable states 
                for (int i = 0; i < 8; i++)
                {
                    var x = t.X + dx[i];
                    var y = t.Y + dy[i];

                    // not yet visited & inside board, push that state into queue 
                    if (IsInside(x, y, n) && !visit[x, y])
                    {
                        visit[x, y] = true;
                        q.Enqueue(new Cell(x, y, t.Dis + 1));
                    }
                }
            }
            return int.MaxValue;
        }
        public static void Main1(String[] args)
        {
            int N = 30;
            int[] knightPos = { 1, 1 };
            int[] targetPos = { 30, 30 };
            Console.WriteLine(MinStepToReachTarget(knightPos, targetPos, N));
        }
    }

}