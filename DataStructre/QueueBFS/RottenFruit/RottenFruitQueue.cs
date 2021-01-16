using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure.QueueBFS.RottenFruit
{
    class RottenFruitQueue
    {
        public class Coordinates
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Coordinates(int xx, int yy)
            {
                X = xx;
                Y = yy;
            }
        }

        readonly Queue<Coordinates> _queue = new Queue<Coordinates>();
        private int _count = 0;

        public int RottenFruit(int[,] arr)
        {
            #region Add All Existing rotten fruit
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 2)
                        _queue.Enqueue(new Coordinates(i, j));
                }
            }
            #endregion

            _queue.Enqueue(new Coordinates(-1, -1));

            var flag = false;
            while (_queue.Count != 0)
            {
                while (IsNotDelimiter())
                {
                    var ele = _queue.Dequeue();

                    if (IsFresh(arr, ele.X - 1, ele.Y))
                    {
                        arr[ele.X - 1, ele.Y] = 2;
                        _queue.Enqueue(new Coordinates(ele.X - 1, ele.Y));
                        if (!flag)
                        {
                            flag = true;
                            _count++;
                        }

                    }

                    if (IsFresh(arr, ele.X, ele.Y + 1))
                    {
                        arr[ele.X, ele.Y + 1] = 2;
                        _queue.Enqueue(new Coordinates(ele.X, ele.Y + 1));
                        if (!flag)
                        {
                            flag = true;
                            _count++;
                        }

                    }

                    if (IsFresh(arr, ele.X + 1, ele.Y))
                    {
                        arr[ele.X + 1, ele.Y] = 2;
                        _queue.Enqueue(new Coordinates(ele.X + 1, ele.Y));
                        if (!flag)
                        {
                            flag = true;
                            _count++;
                        }
                    }

                    if (IsFresh(arr, ele.X, ele.Y - 1))
                    {
                        arr[ele.X, ele.Y - 1] = 2;
                        _queue.Enqueue(new Coordinates(ele.X, ele.Y - 1));
                        if (!flag)
                        {
                            flag = true;
                            _count++;
                        }

                    }

                }

                _queue.Dequeue(); // its a delimiter
                flag = false;
                if (_queue.Count() != 0)
                    _queue.Enqueue(new Coordinates(-1, -1));

            }

            return IfAnyFreshOrangesLeft(arr) ? -1 : _count;
        }

        public bool IfAnyFreshOrangesLeft(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == 1)
                        return true;
                }
            }

            return false;
        }

        public bool IsFresh(int[,] arr, int xx, int yy)
        {
            return xx >= 0 && xx < arr.GetLength(0)
                && yy >= 0 && yy < arr.GetLength(1)
                && arr[xx, yy] == 1;
        }

        public bool IsNotDelimiter()
        {
            return !(_queue.Peek().X == -1 && _queue.Peek().Y == -1);
        }

        public static void Main1(string[] args)
        {
            int[,] arr = {
                {2, 1, 0, 2, 1},
                {1, 0, 1, 2, 1},
                {1, 0, 0, 2, 1},
            };
            Console.WriteLine(new RottenFruitQueue().RottenFruit(arr));
            Console.ReadKey();
        }
    }
}
