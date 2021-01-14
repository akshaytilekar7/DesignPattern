using System;
using System.Collections.Generic;

namespace DataStructure.Tree
{
    class TreeNodeProblem
    {
        public int NumNodes(Node cur)
        {
            if (cur == null)
                return 0;
            return 1 + NumNodes(cur.rChild) + NumNodes(cur.lChild);
        }

        public int SumAllBt(Node cur)
        {
            if (cur == null)
                return 0;

            return (cur.value + SumAllBt(cur.lChild) + SumAllBt(cur.lChild));
        }

        public int NumLeafNodes(Node cur)
        {
            if (cur == null)
                return 0;

            if (cur.lChild == null && cur.rChild == null)
                return 1;

            return NumLeafNodes(cur.rChild) + NumLeafNodes(cur.lChild);
        }

        public int NumFullNodesBt(Node cur)
        {
            if (cur == null)
                return 0;
            var count = NumFullNodesBt(cur.rChild) + NumFullNodesBt(cur.lChild);
            if (cur.rChild != null && cur.lChild != null)
                count++;
            return count;
        }

        public int NumFullNodesBt2Good(Node root)
        {
            if (root == null)
                return 0;

            if (root.lChild != null && root.rChild != null)
                return 1 + NumFullNodesBt2Good(root.lChild) + NumFullNodesBt2Good(root.rChild);

            if (root.lChild == null && root.rChild != null)
                return NumFullNodesBt2Good(root.rChild);

            if (root.rChild == null && root.lChild != null)
                return NumFullNodesBt2Good(root.lChild);

            return 0;

        }

        static bool SearchBtUtil(Node node, int key)
        {
            if (node == null)
                return false;

            if (node.value == key)
                return true;

            bool res1 = SearchBtUtil(node.lChild, key);
            if (res1) return true;

            bool res2 = SearchBtUtil(node.rChild, key);
            return res2;
        }

        public int FindMaxBt(Node cur)
        {
            if (cur == null)
                return int.MinValue;

            int max = cur.value;

            var left = FindMaxBt(cur.lChild);
            var right = FindMaxBt(cur.rChild);

            if (left > max)
                max = left;
            if (right > max)
                max = right;

            return max;
        }

        public int FindMaxBt2NotWorking(Node cur, int max)
        {
            if (cur == null)
                return int.MinValue;

            if (cur.value > max) max = cur.value;

            FindMaxBt2NotWorking(cur.lChild, max);
            FindMaxBt2NotWorking(cur.rChild, max);

            return max;
        }

        public int Max;
        public void FindMaxBt3(Node cur)
        {
            if (cur == null)
                return;

            if (cur.value > Max) Max = cur.value;

            FindMaxBt3(cur.lChild);
            FindMaxBt3(cur.rChild);
        }

        public int TreeDepth(Node cur)
        {
            if (cur == null)
                return 0;

            int lDepth = TreeDepth(cur.lChild);
            int rDepth = TreeDepth(cur.rChild);
            return 1 + (lDepth > rDepth ? lDepth : rDepth);
        }

        public int MaxLengthPathOrDiameterTodo(Node cur)
        {
            if (cur == null)
                return 0;

            var leftPath = TreeDepth(cur.lChild);
            var rightPath = TreeDepth(cur.rChild);
            var max = leftPath + rightPath + 1;

            var leftMax = MaxLengthPathOrDiameterTodo(cur.lChild);
            var rightMax = MaxLengthPathOrDiameterTodo(cur.rChild);

            if (leftMax > max)
                max = leftMax;
            if (rightMax > max)
                max = rightMax;

            return max;
        }

        private static int _diameter;

        public int DiameterOfBinaryTree(Node root)
        {
            _diameter = 0;
            getDepth(root);
            return _diameter;
        }

        private int getDepth(Node root)
        {
            if (root == null)
                return 0;

            int leftDepth = getDepth(root.lChild);
            int rightDepth = getDepth(root.rChild);

            _diameter = Math.Max(_diameter, leftDepth + rightDepth);

            return Math.Max(leftDepth, rightDepth) + 1;
        }

        public bool IsEqual(Node node1, Node node2)
        {
            if (node1 == null && node2 == null)
                return true;

            if (node1 == null || node2 == null)
                return false;

            return
                (IsEqual(node1.lChild, node2.lChild)
                 && IsEqual(node1.rChild, node2.rChild)
                 && (node1.value == node2.value));
        }

        public Node CopyTree()
        {
            var tree2 = CopyTree(new Node().GetRoot());
            return tree2;
        }

        public Node CopyTree(Node cur)
        {
            if (cur == null)
                return null;

            Node temp = new Node(cur.value)
            {
                lChild = CopyTree(cur.lChild),
                rChild = CopyTree(cur.rChild)
            };
            return temp;
        }

        public Node CopyMirrorTree(Node cur)
        {
            if (cur == null)
                return null;

            var temp = new Node(cur.value)
            {
                rChild = CopyMirrorTree(cur.lChild),
                lChild = CopyMirrorTree(cur.rChild)
            };
            return temp;
        }

        public bool IsCompleteTree(Node root)
        {
            Queue<Node> que = new Queue<Node>();
            bool noLeftChild = false;
            if (root != null)
                que.Enqueue(root);

            while (que.Count != 0)
            {
                var temp = que.Dequeue();
                if (temp.lChild != null)
                {
                    if (noLeftChild)
                        return false;
                    que.Enqueue(temp.lChild);
                }
                else
                {
                    noLeftChild = true;
                }

                if (temp.rChild != null)
                {
                    if (noLeftChild)
                        return false;
                    que.Enqueue(temp.rChild);
                }
                else
                    noLeftChild = true;
            }
            return true;
        }

        public bool IsCompleteTreeUtil(Node cur, int index, int count)
        {
            if (cur == null)
                return true;
            if (index > count)
                return false;

            return
               IsCompleteTreeUtil(cur.lChild, index * 2 + 1, count)
            && IsCompleteTreeUtil(cur.rChild, index * 2 + 2, count);
        }

    }
}
