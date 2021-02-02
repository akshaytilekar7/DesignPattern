using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    public class Coordinate
    {
        public int X;
        public int Y;

        public Coordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    public class MatrixApp
    {

        int ROW = 4;
        int COL = 5;

        Queue<Coordinate> q = new Queue<Coordinate>();
        int _count = 0;

        public int TimeToRotOranges(int[,] mat)
        {

            #region add rotten in Queue and Delimeter 
            for (int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COL; j++)
                {
                    if (mat[i, j] == 2)
                    {
                        q.Enqueue(new Coordinate(i, j));
                    }
                }
            }

            q.Enqueue(new Coordinate(-1, -1));

            #endregion


            var flag = false;

            while (q.Count() != 0)
            {

                while (!IfPeekDelimiter(q.Peek()))
                {
                    Coordinate element = q.Dequeue();

                    if (IsFreshOrange(mat, element.X - 1, element.Y))
                    {
                        mat[element.X - 1, element.Y] = 2;
                        q.Enqueue(new Coordinate(element.X - 1, element.Y));

                        if (!flag)
                        {
                            flag = true;
                            _count++;
                        }
                    }

                    if (IsFreshOrange(mat, element.X, element.Y + 1))
                    {
                        mat[element.X, element.Y + 1] = 2;
                        q.Enqueue(new Coordinate(element.X, element.Y + 1));

                        if (!flag)
                        {
                            flag = true;
                            _count++;
                        }
                    }

                    if (IsFreshOrange(mat, element.X + 1, element.Y))
                    {
                        mat[element.X + 1, element.Y] = 2;
                        q.Enqueue(new Coordinate(element.X + 1, element.Y));
                        if (!flag)
                        {
                            flag = true;
                            _count++;
                        }
                    }

                    if (IsFreshOrange(mat, element.X, element.Y - 1))
                    {
                        mat[element.X, element.Y - 1] = 2;
                        q.Enqueue(new Coordinate(element.X, element.Y - 1));
                        if (!flag)
                        {
                            flag = true;
                            _count++;
                        }
                    }
                }

                q.Dequeue();
                flag = false;
                if (q.Count() != 0)
                    q.Enqueue(new Coordinate(-1, -1));
            }

            return IfAnyFreshOrangesLeft(mat) ? -1 : _count;

        }

        public bool IfPeekDelimiter(Coordinate c)
        {
            return c.X == -1 && c.Y == -1;
        }

        public bool IsFreshOrange(int[,] mat, int x, int y)
        {
            return x >= 0 && x < ROW
                          && y >= 0 && y < COL
                          && mat[x, y] == 1;
        }

        public bool IfAnyFreshOrangesLeft(int[,] mat)
        {
            for (int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COL; j++)
                {
                    if (mat[i, j] == 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static void Main1(String[] args)
        {

            MatrixApp a = new MatrixApp();

            int[,] mat =
            {
                {0, 2, 0, 0, 2},
                {0, 1, 0, 1, 1},
                {0, 1, 0, 1, 2},
                {2, 1, 0, 2, 0}
            };

            Console.WriteLine(a.TimeToRotOranges(mat));
        }

    }
}