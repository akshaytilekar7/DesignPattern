using System;
using System.Collections.Generic;

namespace DataStructure.Tree
{
    /*
    DFS can be done using stack. 
    root is added to the stack. 
    traversed until the stack is empty. 
    In each iteration, 
        ele popped from the stack
            its value is printed to screen. 
            then L and R is added to stack.
    */

    class DFS
    {
        public void PrintDepthFirst(Node root)
        {
            Stack<Node> stk = new Stack<Node>();
            if (root != null)
                stk.Push(root);

            while (stk.Count != 0)
            {
                var temp = stk.Pop();
                Console.WriteLine(temp.value);
                if (temp.rChild != null)
                    stk.Push(temp.rChild);
                if (temp.lChild != null)
                    stk.Push(temp.lChild);
            }
        }
    }
}
