namespace CSharp.Logic
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }


    }
    class TreeHelper
    {
        public int CountOfNodes(TreeNode root)
        {
            if (root == null)
                return 0;

            var l = CountOfNodes(root.left);
            var r = CountOfNodes(root.right);
            return 1 + l + r;
        }

        public bool IsCousins(TreeNode root, int x, int y)
        {
            var h1 = GetHeight(root, x, 0);
            var h2 = GetHeight(root, y, 0);

            if (h1 != h2)
                return false;

            var p1 = GetParent(root, x);
            var p2 = GetParent(root, y);

            return p1 != p2;

        }

        private int GetParent(TreeNode root, int data)
        {
            if (root == null)
                return 0;

            if (root.val == data)
                return 0;

            if (root.left?.val == data || root.right?.val == data)
                return root.val;

            var lf = GetParent(root.left, data);
            if (lf != 0)
                return lf;

            var rf = GetParent(root.right, data);
            if (rf != 0)
                return rf;

            return 0;


        }

        public int GetHeight(TreeNode root, int x, int height)
        {
            if (root == null) return 0;
            if (root.val == x) return height;

            int level = GetHeight(root.left, x, height + 1);
            if (level != 0) return level;

            return GetHeight(root.right, x, height + 1);
        }
    }
}
