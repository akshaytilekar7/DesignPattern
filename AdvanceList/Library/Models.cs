using AdvanceList.DataGenerator;

namespace AdvanceList.Library
{
    public class Node
    {
        public Employee Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node Parent { get; set; }

    }

    public class AvlTree
    {
        public Node Root { get; set; }
        public int Count { get; set; }
    }
}
