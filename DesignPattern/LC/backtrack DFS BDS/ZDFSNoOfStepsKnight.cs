using System;

namespace CSharp
{
    public class Demo4
    {
        public static void Stpes(int size, int currCol, int currRow, int[,] traversed, int dist)
        {
            if (currCol < 0 || currCol >= size || currRow < 0 || currRow >= size)
                return;

            //if already visited
            if (traversed[currCol, currRow] <= dist)
                return;

            traversed[currCol, currRow] = dist;

            // each line corresponding to 8 direction.
            Stpes(size, currCol - 2, currRow - 1, traversed, dist + 1);
            Stpes(size, currCol - 2, currRow + 1, traversed, dist + 1);
            Stpes(size, currCol + 2, currRow - 1, traversed, dist + 1);
            Stpes(size, currCol + 2, currRow + 1, traversed, dist + 1);
            Stpes(size, currCol - 1, currRow - 2, traversed, dist + 1);
            Stpes(size, currCol + 1, currRow - 2, traversed, dist + 1);
            Stpes(size, currCol - 1, currRow + 2, traversed, dist + 1);
            Stpes(size, currCol + 1, currRow + 2, traversed, dist + 1);
        }
        public static int StepsOfKnight(int size, int srcX, int srcY, int dstX, int dstY)
        {
            int[,] traversed = new int[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    traversed[i, j] = int.MaxValue;

            Stpes(size, srcX - 1, srcY - 1, traversed, 0);
            int retval = traversed[dstX - 1, dstY - 1];
            return retval;
        }

        public static void Main1(string[] args)
        {
            Console.WriteLine(StepsOfKnight(20, 1, 1, 3, 2));
        }

    }

}