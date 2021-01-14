using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure.Tree
{
    /*
     Level order traversal BFS  -    
        -   the root node added to a queue. 
            traversal of tree is done until the queue is empty.
            When we traverse the tree, we first remove an element from the queue, 
            print the value stored node 
            and left child & right child will be added to the queue
    */
    class BFS
    {
        public void PrintBredthFirst(Node root)
        {
            Queue<Node> que = new Queue<Node>();
            if (root != null)
                que.Enqueue(root);
            while (que.Count != 0)
            {
                var temp = que.Dequeue();
                Console.Write(" " + temp.value);
                if (temp.lChild != null)
                    que.Enqueue(temp.lChild);

                if (temp.rChild != null)
                    que.Enqueue(temp.rChild);
            }

            Console.WriteLine();
        }

        // will use two queue to preform level order traversal.
        // Alternatively we will process queues and put the children of elements of
        //queue into another queue so that when each level is processed we can print
        //the output in different line.
        public void PrintLevelOrderLineByLine(Node root)
        {
            Queue<Node> que1 = new Queue<Node>();
            Queue<Node> que2 = new Queue<Node>();
            if (root != null)
            {
                que1.Enqueue(root);
            }
            while (que1.Count != 0 || que2.Count != 0)
            {
                Node temp;
                while (que1.Count != 0)
                {
                    temp = que1.Dequeue();
                    Console.Write(" " + temp.value);
                    if (temp.lChild != null)
                        que2.Enqueue(temp.lChild);
                    if (temp.rChild != null)
                        que2.Enqueue(temp.rChild);
                }
                Console.WriteLine("");
                while (que2.Count != 0)
                {
                    temp = (Node)que2.Dequeue();
                    Console.Write(" " + temp.value);
                    if (temp.lChild != null)
                        que1.Enqueue(temp.lChild);
                    if (temp.rChild != null)
                        que1.Enqueue(temp.rChild);
                }
                Console.WriteLine("");
            }
        }

        public void PrintLevelOrderLineByLine2(Node root)
        {
            Queue<Node> que = new Queue<Node>();
            que.Enqueue(root);

            while (que.Count != 0)
            {
                int count = que.Count;
                while (count > 0)
                {
                    Node temp = que.Dequeue();
                    Console.Write(" " + temp.value);
                    if (temp.lChild != null)
                        que.Enqueue(temp.lChild);
                    if (temp.rChild != null)
                        que.Enqueue(temp.rChild);
                    count--;
                }
                Console.WriteLine("");
            }
        }

        //Stacks are last in first out, so two stacks are used to process
        //each level alternatively.The nodes are added and processed in such an
        //order that nodes are printed in spiral order.
        public void PrintSpiralTree(Node root)
        {
            Stack<Node> stk1 = new Stack<Node>();
            Stack<Node> stk2 = new Stack<Node>();
            stk1.Push(root);
            while (stk1.Count != 0 || stk2.Count != 0)
            {
                while (stk1.Count != 0)
                {
                    var temp = stk1.Pop();
                    Console.Write(" " + temp.value);
                    if (temp.rChild != null)
                        stk2.Push(temp.rChild);
                    if (temp.lChild != null)
                        stk2.Push(temp.lChild);
                }
                while (stk2.Count != 0)
                {
                    var temp = stk2.Pop();
                    Console.Write(" " + temp.value);
                    if (temp.lChild != null)
                        stk1.Push(temp.lChild);
                    if (temp.rChild != null)
                        stk1.Push(temp.rChild);
                }
            }
        }

        public void SpiralOrder(Node root)
        {

            Queue<Node> que = new Queue<Node>();
            que.Enqueue(root);
            int dir = 0; //  0 R to L and 1 : L to R  
            while (que.Any())
            {
                int size = que.Count();
                while (size > 0)
                {
                    if (dir == 0)
                    {
                        Node temp = que.Dequeue();
                        if (temp.rChild != null)
                            que.Enqueue(temp.rChild);
                        if (temp.lChild != null)
                            que.Enqueue(temp.lChild);
                        Console.Write(temp.value + " ");
                    }
                    else
                    {
                        Node temp = que.Dequeue();
                        if (temp.lChild != null)
                            que.Enqueue(temp.lChild);
                        if (temp.rChild != null)
                            que.Enqueue(temp.rChild);
                        Console.Write(temp.value + " ");
                    }
                    size--;
                }
                Console.WriteLine();
                // dir = 1 - dir;
                dir = dir == 0 ? 1 : 0;
            }
        }
        public static void Main1(string[] args)
        {
            //Console.WriteLine("BFS");
            //var x1 = new BFS();
            //x1.PrintLevelOrderLineByLine2(new Node().GetRoot());
            //Console.WriteLine();
            //x1.PrintSpiralTree(new Node().GetRoot());
            //Console.WriteLine();
            //x1.SpiralOrder(new Node().GetRoot());
            //Console.WriteLine("DFS");
            var x2 = new TreeNodeProblem();
            var s1 = x2.FindMaxBt(new Node().GetRoot());
            x2.FindMaxBt3(new Node().GetRoot());
            Console.WriteLine(s1);
            Console.WriteLine(x2.Max);

            var s3 = x2.FindMaxBt2NotWorking(new Node().GetRoot(), int.MinValue);
            Console.WriteLine(s3);

            Console.WriteLine();
        }
    }
}
