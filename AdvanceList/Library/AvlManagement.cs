using AdvanceList.DataGenerator;

namespace AdvanceList.Library
{
    public class AvlManagement
    {
        public readonly AvlTree _avlTree;
        public AvlManagement()
        {
            this._avlTree = new AvlTree();
            this._avlTree.Root = null;
        }
        public Node GetNewNode(Employee data)
        {
            return new Node() { Data = data, Left = null, Right = null, Parent = null };
        }
        public void Insert(Employee data)
        {
            var newNode = InsertHelper(data);
            InsertFix(newNode);
        }
        private Node InsertHelper(Employee data)
        {
            var z = GetNewNode(data);

            if (_avlTree.Root == null)
            {
                _avlTree.Root = z;
                return z;
            }

            var node = _avlTree.Root;
            while (true)
            {
                if (data.Id <= node.Data.Id)
                {
                    if (node.Left == null)
                    {
                        node.Left = z;
                        z.Parent = node;
                        return z;
                    }
                    node = node.Left;
                }
                else
                {
                    if (node.Right == null)
                    {
                        node.Right = z;
                        z.Parent = node;
                        return z;
                    }
                    node = node.Right;
                }
            }
        }
        private void InsertFix(Node child)
        {
            if (_avlTree.Root == child) return;

            Node parent = child.Parent;
            Node grandparent = null;
            if (parent != null)
                grandparent = parent.Parent;

            if (child == null || parent == null || grandparent == null)
                return;

            while (grandparent != null)
            {
                var imbalanceCount = GetBalanceOfNode(grandparent);
                if (imbalanceCount > 1 || imbalanceCount < -1)
                    break;

                child = child.Parent;
                parent = parent.Parent;
                grandparent = grandparent.Parent;
            }

            if (grandparent == null)
                return;

            FixupByRotation(child, parent, grandparent);
        }
        public void Delete(int data)
        {
            var node = GetNode(data);
            var grandparent = DeleteHelper(node);
            DeleteFixup(grandparent);
        }
        private Node DeleteHelper(Node z)
        {
            Node grandparent = null;
            if (z.Left == null)
            {
                if (_avlTree.Root == z)
                    _avlTree.Root = z.Right;
                else if (z == z.Parent.Left)
                    z.Parent.Left = z.Right;
                else if (z == z.Parent.Right)
                    z.Parent.Right = z.Right;
                if (z.Right != null)
                    z.Right.Parent = z.Parent; //////
                grandparent = z.Right;
            }
            else if (z.Right == null)
            {
                if (_avlTree.Root == z)
                    _avlTree.Root = z.Left;
                else if (z == z.Parent.Left)
                    z.Parent.Left = z.Left;
                else if (z == z.Parent.Right)
                    z.Parent.Right = z.Left;
                if (z.Left != null)
                    z.Left.Parent = z.Parent;

                grandparent = z.Left;
            }
            else
            {
                var w = z.Right;
                while (w.Left != null)
                    w = w.Left;

                if (z.Right != w)
                {
                    w.Parent.Left = w.Right;
                    if (w.Right != null)
                        w.Right.Parent = w.Parent;

                    w.Right = z.Right;
                    w.Right.Parent = w;
                }

                w.Left = z.Left;
                w.Left.Parent = w;

                if (_avlTree.Root == z)
                    _avlTree.Root = w;
                else if (z == z.Parent.Left)
                    z.Parent.Left = w;
                else if (z == z.Parent.Right)
                    z.Parent.Right = w;

                w.Parent = z.Parent;
                grandparent = w;
            }
            return grandparent;
        }
        private void DeleteFixup(Node grandparent)
        {
            Node child = null;
            Node parent = null;
            while ((grandparent = FindImbalanceFromNodeToRoot(grandparent)) != null)
            {
                var heightLeftSubtree = GetHeight(grandparent.Left);
                var heightRightSubtree = GetHeight(grandparent.Right);
                if (heightLeftSubtree > heightRightSubtree)
                    parent = grandparent.Left;
                else
                    parent = grandparent.Right;

                if (parent != null)
                {
                    heightLeftSubtree = GetHeight(parent.Left);
                    heightRightSubtree = GetHeight(parent.Right);
                    if (heightLeftSubtree > heightRightSubtree)
                        child = parent.Left;
                    else
                        child = parent.Right;

                }

                if (child == null || parent == null || grandparent == null)
                    return;

                FixupByRotation(child, parent, grandparent);
            }
        }
        private void FixupByRotation(Node child, Node parent, Node grandparent)
        {
            if (child == parent.Left && parent == grandparent.Left)
            {
                RightRotate(grandparent);
            }
            else if (child == parent.Right && parent == grandparent.Right)
            {
                LeftRotate(grandparent);
            }
            else if (child == parent.Left && parent == grandparent.Right)
            {
                RightRotate(parent);
                LeftRotate(grandparent);
            }
            else if (child == parent.Right && parent == grandparent.Left)
            {
                LeftRotate(parent);
                RightRotate(grandparent);
            }
        }
        public void Inorder()
        {
            Console.WriteLine("[START]");
            Inorder(_avlTree.Root);
            Console.WriteLine("[END]");
        }
        private void Inorder(Node node)
        {
            if (node != null)
            {
                Inorder(node.Left);
                Console.Write(" [{0}] ", node.Data);
                Inorder(node.Right);
            }
        }
        public Node GetMax()
        {
            var node = _avlTree.Root;
            while (node.Right != null)
                node = node.Right;
            return node;
        }
        public Node GetMin()
        {
            var node = _avlTree.Root;
            while (node.Left != null)
                node = node.Left;
            return node;
        }
        public Node GetNode(int data)
        {
            if (_avlTree.Root == null)
                return null;
            var node = _avlTree.Root;
            while (true)
            {
                if (node == null)
                    return null;

                if (node.Data.Id == data)
                    return node;

                if (data < node.Data.Id)
                    node = node.Left;
                else
                    node = node.Right;
            }
        }
        private void LeftRotate(Node x)
        {
            var y = x.Right;
            x.Right = y.Left;
            if (y.Left != null)
                y.Left.Parent = x;

            y.Parent = x.Parent;
            if (x.Parent == null)
                _avlTree.Root = y;
            else if (x == x.Parent.Left)
                x.Parent.Left = y;
            else if (x == x.Parent.Right)
                x.Parent.Right = y;

            y.Left = x;
            x.Parent = y;
        }
        private void RightRotate(Node x)
        {
            var y = x.Left;
            x.Left = y.Right;
            if (y.Right != null)
                y.Right.Parent = x;

            y.Parent = x.Parent;
            if (x.Parent == null)
                _avlTree.Root = y;
            else if (x == x.Parent.Left)
                x.Parent.Left = y;
            else if (x == x.Parent.Right)
                x.Parent.Right = y;

            y.Right = x;
            x.Parent = y;
        }
        public int GetHeight(Node node)
        {
            if (node == null) return 0;
            return 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
        }
        private int GetBalanceOfNode(Node node)
        {
            if (node == null) return 0;
            int left = GetHeight(node.Left);
            int right = GetHeight(node.Right);
            return left - right;
        }
        private Node FindImbalanceFromNodeToRoot(Node node) 
        {
            if (node == null) return null;
            var travel = node;
            while (travel.Parent != null)
            {
                int imbalanceCount = GetBalanceOfNode(travel);
                if(imbalanceCount < -1 || imbalanceCount > 1)
                    return travel;
                travel = travel.Parent;
            }
            return null;
        }

    }
}
