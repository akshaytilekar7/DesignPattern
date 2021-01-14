using System;
using System.Collections.Generic;

namespace DataStructure.QueueBFS.Queue
{

    public class JosephusQueue
    {
        public static int Josephus(int n, int k)
        {
            Queue<int> q = new Queue<int>();
            for (int i = 1; i <= n; i++)
                q.Enqueue(i);

            while (q.Count > 1)
            {
                int x = k;
                while (q.Count > 0 && x - 1 > 0)
                {
                    q.Enqueue(q.Dequeue());
                    x--;
                }
                q.Dequeue();
            }
            return q.Dequeue();
        }

        public static void Main1(string[] args)
        {
            var d = Josephus(3, 2);
            Console.WriteLine(d);
        }
    }

}