using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Logic
{

    /*
     *
     *  //int[] arr = new int[] { 1, 2, 3, 0, 4, 0, 5 };
            //TreeNode root = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            //root.right.right = new TreeNode(5);

            TreeNode root = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.left.left.left = new TreeNode(6);



            var res = new Solution().IsCousins(root, 4, 3);

     */
    public class SolutionTreeNode
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

        public bool IsCousins(TreeNode root, int x, int y)
        {
            var h1 = 0;//GetHeight(root, x, 0);
            var h2 = GetHeight(root, 5, 0);

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
            if (level != 0)
                return level;

            return GetHeight(root.right, x, height + 1);
        }

        public int GetHeight(TreeNode root, int x)
        {
            if (root == null) return 0;
            if (root.val == x) return 0;

            int level = 1 + GetHeight(root.left, x);
            if (level != 0) return level;

            return 1 + GetHeight(root.right, x);
        }
        public static int RecursiveRob1(int[] arr, int n)
        {
            if (n == 1)
                return arr[0];

            if (n == 2)
                return Math.Max(arr[0], arr[1]);

            int max1Sum = arr[0];


            for (int i = 0; i < n; i++)
            {
                if (i + 2 <= n && i + 3 <= n)
                {
                    if (arr[i + 2] > arr[i + 3])
                    {
                        max1Sum += arr[i + 2];
                        i = i + 1;
                    }
                    else
                    {
                        max1Sum += arr[i + 3];
                        i = i + 2;
                    }
                }
            }

            int max2Sum = arr[1];
            for (int i = 1; i < n; i++)
            {
                if ((i + 2) < n && (i + 3) < n)
                {

                    if (arr[i + 2] > arr[i + 3])
                    {
                        max2Sum += arr[i + 2];
                        i = i + 1;
                    }
                    else
                    {
                        max2Sum += arr[i + 3];
                        i = i + 2;
                    }
                }
            }
            return Math.Max(max1Sum, max2Sum);
        }
        public int MajorityElement(int[] nums)
        {
            if (nums.Length == 1) return nums[0];

            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            int middle = (int)Math.Floor(nums.Length / 2.0);
            foreach (var no in nums)
            {
                if (dictionary.ContainsKey(no))
                {
                    dictionary[no]++;
                    dictionary.TryGetValue(no, out var val);
                    if (val > middle)
                        return no;
                }
                else dictionary.Add(no, 1);
            }

            return -1;

        }
        public static int FirstUniqChar(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (dic.ContainsKey(c))
                {
                    ++dic[c];
                }
                else dic.Add(c, 1);
            }

            if (dic.ContainsValue(1))
                return s.IndexOf(dic.FirstOrDefault(x => x.Value == 1).Key);
            return -1;
        }
        public class Solution1
        {
            public int FirstUniqChar1(string s)
            {
                var charAndCount = new int[256];

                foreach (var c in s)
                {
                    charAndCount[c]++;
                }

                for (int i = 0; i < s.Length; i++)
                {
                    if (charAndCount[s[i]] == 1)
                    {
                        return i;
                    }
                }
                return -1;
            }
        }
    }
}
