/*
A binary tree 
    -   each node has at most two children 0, 1 or 2
        1.  The maximum number of nodes on level i of a binary tree is 2i, where i >= 1
        2.  The maximum number of nodes in a binary tree of depth k is 2k+1, where k >= 1
        3.  There is exactly one path from the root to any nodes in a tree.
        4.  tree with N nodes have exactly N-1 edges connecting these nodes.
        5.  The height of a complete binary tree of N nodes is log2N


Types
    complete binary tree
        -   every level except the last one is completely filled. 
            All nodes in the left are filled first, then the right one. 
            binary heap is an example of a complete binary tree

    full binary tree
        -   each node has exactly zero or two children

    Perfect binary tree
        -   each non-leaf node has exactly two child nodes.

    Right skewed binary tree
        -   each node is has a right child or no child

    Height-balanced Binary Tree
        -   binary tree such that the left & right subtrees for any given node differs in height by max one
        -   AVL and RB (each complete binary tree is also height balance tree)


Traversal Time Complexity: O(n), Space Complexity: O(n)
    Pre-Order Traversal        -   ROOT LEFT RIGHT
    In-Order Traversal         -   LEFT ROOT RIGHT [sorted list in increasing order]
    PostOrder Traversal        -   LEFT RIGHT ROOT 
    BFS
    DFS



*/ 