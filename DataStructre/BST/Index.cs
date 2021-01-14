/*
A binary search tree (BST) 

    • The key in the lChild subtree is less than the key in its parent node.
    • The key in the rChild subtree is greater the key in its parent node.
    • No duplicate key is allowed.

*/

using DataStructure.Tree;
using System;
using System.Collections.Generic;

namespace DataStructure.BST
{
    class Bst
    {
        public void CreateBinaryTree(int[] arr)
        {
            var root = CreateBinaryTree(arr, 0, arr.Length - 1);
        }

        private Node CreateBinaryTree(int[] arr, int start, int end)
        {
            if (start > end)
                return null;

            int mid = (start + end) / 2;

            var cur = new Node(arr[mid])
            {
                lChild = CreateBinaryTree(arr, start, mid - 1),
                rChild = CreateBinaryTree(arr, mid + 1, end)
            };
            return cur;
        }

        private Node InsertNode(Node node, int value)
        {
            if (node == null)
                node = new Node(value);
            else
            {
                if (node.value > value)
                    node.lChild = InsertNode(node.lChild, value);
                else
                    node.rChild = InsertNode(node.rChild, value);
            }
            return node;
        }

        public bool Find(int value, Node root)
        {
            while (root != null)
            {
                if (root.value == value)
                    return true;

                root = root.value > value ? root.lChild : root.rChild;
            }
            return false;
        }

        private Node FindMinNode(Node node)
        {
            while (node.lChild != null)
                node = node.lChild;
            return node;
        }

        public int FindMin(Node node)
        {
            if (node == null)
                return int.MaxValue;

            while (node.lChild != null)
                node = node.lChild;

            return node.value;
        }

        public bool IsBst()
        {
            return IsBst(new Node(), int.MinValue, int.MaxValue);
        }

        private bool IsBst(Node cur, int min, int max)
        {
            if (cur == null)
                return true;

            if (cur.value < min || cur.value > max)
                return false;

            return IsBst(cur.lChild, min, cur.value) &&
                   IsBst(cur.rChild, cur.value, max);

            // In order traversal and check if it is increasing order
        }

        static Boolean IsBst(Node root, Node lChild, Node rChild)
        {
            if (root == null)
                return true;

            if (lChild != null && root.value <= lChild.value)
                return false;

            if (rChild != null && root.value >= rChild.value)
                return false;

            return IsBst(root.lChild, lChild, root) &&
                   IsBst(root.rChild, root, rChild);
        }

        /// <summary>
        /// 1.  leaf: Simply remove from the tree.
        /// 2.  one child: Copy the child to the node and delete the child
        /// 3.  two children: inOrder successor of the node
        ///         Copy contents of the inOrder successor to the node and
        ///         delete the inOrder successor
        /// inOrder successor is needed only when rChild child is not empty.
        /// </summary>
        private Node DeleteNode(Node node, int value)
        {
            if (node == null) return null;

            if (node.value != value)
            {
                if (node.value > value)
                    node.lChild = DeleteNode(node.lChild, value);
                else
                    node.rChild = DeleteNode(node.rChild, value);
            }
            else
            {
                // 1st scenario
                if (node.lChild == null && node.rChild == null)
                    return null;

                // 2st scenario
                Node temp;
                if (node.lChild == null)
                {
                    temp = node.rChild;
                    return temp;
                }

                if (node.rChild == null)
                {
                    temp = node.lChild;
                    return temp;
                }

                // 3rd scenario [2 children]
                node.value = FindMin(node.rChild);
                node.rChild = DeleteNode(node.rChild, node.value); // delete that copy
            }

            return node;
        }


        private int Lca(Node cur, int n1, int n2)
        {
            if (cur == null)
                return int.MaxValue;

            // If both n1 and n2 are smaller than root, then LCA lies in lChild
            if (cur.value > n1 && cur.value > n2)
                return Lca(cur.lChild, n1, n2);

            if (cur.value < n1 && cur.value < n2)
                return Lca(cur.rChild, n1, n2);

            return cur.value;
        }

        private Node TrimOutsideRange(Node cur, int min, int max)
        {
            if (cur == null)
                return null;

            cur.lChild = TrimOutsideRange(cur.lChild, min, max);
            cur.rChild = TrimOutsideRange(cur.rChild, min, max);

            if (cur.value < min)
                return cur.rChild;

            if (cur.value > max)
                return cur.lChild;

            return cur;
        }

        public Node TrimBST(Node root, int L, int R)
        {
            if (root == null)
                return null;

            root.lChild = TrimBST(root.lChild, L, R);
            root.rChild = TrimBST(root.rChild, L, R);


            if (root.value < L)
            {
                // all the values in lChild is guaranteed to be lower than x, so only check rChild
                if (root.rChild != null && root.rChild.value >= L)
                    return root.rChild;
                return null;
            }

            if (root.value > R)
            {
                // all the values in rChild is guaranteed to be higher than x, so only check lChild
                if (root.lChild != null && root.lChild.value <= R)
                    return root.lChild;
                return null;
            }

            return root;
        }

        private void PrintInRangeByInOrderTraversal(Node root, int min, int max)
        {
            if (root == null)
                return;

            PrintInRangeByInOrderTraversal(root.lChild, min, max);

            if (root.value >= min && root.value <= max)
                Console.WriteLine(root.value + " ");

            PrintInRangeByInOrderTraversal(root.rChild, min, max);
        }

        public int GetCeilBst(int val, Node cur)
        {
            int ceil = int.MinValue;
            while (cur != null)
            {
                if (cur.value == val)
                {
                    ceil = cur.value;
                    break;
                }

                if (cur.value > val)
                {
                    ceil = cur.value;
                    cur = cur.lChild;
                }
                else
                    cur = cur.rChild;
            }
            return ceil;
        }

        public int GetFloorBst(int val, Node cur)
        {
            int floor = int.MaxValue;
            while (cur != null)
            {
                if (cur.value == val)
                {
                    floor = cur.value;
                    break;
                }

                if (cur.value > val)
                    cur = cur.lChild;
                else
                {
                    floor = cur.value;
                    cur = cur.rChild;
                }
            }
            return floor;
        }

        public bool IsBstArray(int[] preOrder, int size)
        {
            Stack<int> stk = new Stack<int>();
            int root = -999999;
            for (int i = 0; i < size; i++)
            {
                var value = preOrder[i];
                // If value of the rChild child is less than root.
                if (value < root)
                    return false;

                // First lChild child values will be popped
                // Last popped value will be the root.
                while (stk.Count > 0 && stk.Peek() < value)
                    root = stk.Pop();

                // add current value to the stack.
                stk.Push(value);
            }
            return true;
        }
    }
}