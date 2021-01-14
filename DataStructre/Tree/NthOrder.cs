using System;
using System.Collections.Generic;

namespace DataStructure.Tree
{
    class NthOrder
    {
        static int _count = 0;
        public static void Main1(string[] args)
        {
            int[] counter = new int[] { 0 };
            NthInOrderWorking(new Node().GetRootComplex(), 16);
            NthInOrderBookWorking(new Node().GetRootComplex(), 16, counter);


            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }


        public static void NthInOrderWorking(Node node, int n)
        {
            if (node == null)
                return;

            NthInOrderWorking(node.lChild, n);
            _count++;
            if (_count == n) Console.WriteLine("{0:D} ", node.value);
            NthInOrderWorking(node.rChild, n);
        }
        public static void NthInOrderBookWorking(Node node, int index, int[] counter)
        {
            if (node != null)
            {
                NthInOrderBookWorking(node.lChild, index, counter);
                counter[0]++;
                if (counter[0] == index)
                    Console.WriteLine(node.value);
                NthInOrderBookWorking(node.rChild, index, counter);
            }
        }


        static void NthPreOrderNode(Node root, int N)
        {
            if (root == null)
                return;
            if (_count <= N)
            {
                _count++;
                if (_count == N) Console.Write(root.value);
                NthPreOrderNode(root.lChild, N);
                NthPreOrderNode(root.rChild, N);
            }
        }


        static void NthPostOrderNode(Node root, int N)
        {
            if (root == null)
                return;
            if (_count <= N)
            {
                NthPostOrderNode(root.lChild, N);
                NthPostOrderNode(root.rChild, N);
                _count++;
                if (_count == N)
                    Console.Write(root.value);
            }
        }

        public void PrintAllPath(Node root)
        {
            Stack<int> stk = new Stack<int>();
            printAllPathUtil(root, stk);
        }

        private void printAllPathUtil(Node curr, Stack<int> stk)
        {
            if (curr == null)
                return;

            stk.Push(curr.value);
            if (curr.lChild == null && curr.rChild == null)
            {
                foreach (int val in stk)
                    Console.Write(val + " ");
                Console.WriteLine();
                stk.Pop();
                return;
            }
            printAllPathUtil(curr.rChild, stk);
            printAllPathUtil(curr.lChild, stk);
            stk.Pop();
        }

        public void IterativePreOrder(Node root)
        {
            Stack<Node> stk = new Stack<Node>();
            Node curr;
            if (root != null)
                stk.Push(root);
            while (stk.Count > 0)
            {
                curr = stk.Pop();
                Console.Write(curr.value + " ");
                if (curr.rChild != null)
                    stk.Push(curr.rChild);
                if (curr.lChild != null)
                    stk.Push(curr.lChild);
            }
        }

        public void IterativePostOrder(Node root)
        {
            Stack<Node> stk = new Stack<Node>();
            Stack<int> visited = new Stack<int>();
            Node curr;
            int vtd;
            if (root != null)
            {
                stk.Push(root);
                visited.Push(0);
            }
            while (stk.Count > 0)
            {
                curr = stk.Pop();
                vtd = visited.Pop();
                if (vtd == 1)
                    Console.Write(curr.value + " ");
                else
                {
                    stk.Push(curr);
                    visited.Push(1);
                    if (curr.rChild != null)
                    {
                        stk.Push(curr.rChild);
                        visited.Push(0);
                    }
                    if (curr.lChild != null)
                    {
                        stk.Push(curr.lChild);
                        visited.Push(0);
                    }
                }
            }
        }
    }
}

