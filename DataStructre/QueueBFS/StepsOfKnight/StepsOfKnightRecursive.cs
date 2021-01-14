using System;

namespace DataStructure.QueueBFS.StepsOfKnight
{
    public class StepsOfKnightRecursive
    {
        public static void Steps(int size, int curCol, int curRow, int[,] traversed, int dist)
        {
            if (curCol < 0 || curCol >= size || curRow < 0 || curRow >= size)
                return;

            //if already visited
            if (traversed[curCol, curRow] <= dist)
                return;

            traversed[curCol, curRow] = dist;

            // each line corresponding to 8 direction.
            Steps(size, curCol - 2, curRow - 1, traversed, dist + 1);
            Steps(size, curCol - 2, curRow + 1, traversed, dist + 1);
            Steps(size, curCol + 2, curRow - 1, traversed, dist + 1);
            Steps(size, curCol + 2, curRow + 1, traversed, dist + 1);
            Steps(size, curCol - 1, curRow - 2, traversed, dist + 1);
            Steps(size, curCol + 1, curRow - 2, traversed, dist + 1);
            Steps(size, curCol - 1, curRow + 2, traversed, dist + 1);
            Steps(size, curCol + 1, curRow + 2, traversed, dist + 1);
        }
        public static int StepsOfKnight(int size, int srcX, int srcY, int dstX, int dstY)
        {
            int[,] traversed = new int[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    traversed[i, j] = int.MaxValue;

            Steps(size, srcX - 1, srcY - 1, traversed, 0);
            int val = traversed[dstX - 1, dstY - 1];
            return val;
        }

        public static void Main1(string[] args)
        {
            Console.WriteLine(StepsOfKnight(20, 1, 1, 3, 2));
        }

    }

}