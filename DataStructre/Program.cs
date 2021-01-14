using DataStructure.Tree;
using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var root = new Node().GetRootComplex();
            Console.WriteLine(p.Search(root, 6));
            Console.ReadLine();
        }

        public bool Search(Node root, int val)
        {
            if (root == null)
                return false;

            var res1 = Search(root.lChild, val);
            if (res1) return true;

            if (root.value == val)
                return true;

            var res2 = Search(root.rChild, val);

            return res2;

        }
    }
}
