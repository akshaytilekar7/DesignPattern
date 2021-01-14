namespace DataStructure.Tree
{
    public class Node
    {
        public int value;
        public Node lChild;
        public Node rChild;

        public Node(int val, Node l = null, Node r = null)
        {
            value = val;
        }

        public Node()
        {

        }
        public Node GetRoot()
        {
            Node tree = new Node(1);
            tree.lChild = new Node(2);
            tree.rChild = new Node(3);
            tree.lChild.lChild = new Node(4);
            tree.lChild.rChild = new Node(5);
            return tree;
        }

        public Node GetRootComplex()
        {
            Node tree = new Node(2);
            tree.lChild = new Node(7);
            tree.rChild = new Node(5);
            tree.lChild.rChild = new Node(6);
            tree.lChild.rChild.lChild = new Node(1);
            tree.lChild.rChild.rChild = new Node(11);
            tree.rChild.rChild = new Node(9);
            tree.rChild.rChild.lChild = new Node(4);
            tree.rChild.rChild.lChild.rChild = new Node(41);
            tree.rChild.rChild.lChild.lChild = new Node(42);
            tree.rChild.rChild.lChild.lChild.rChild = new Node(45);
            tree.rChild.rChild.lChild.lChild.rChild.lChild = new Node(48);
            tree.rChild.rChild.lChild.lChild.rChild.lChild.rChild = new Node(48);
            tree.rChild.rChild.lChild.lChild.rChild.lChild.rChild = new Node(48);


            return tree;
        }
    }
}