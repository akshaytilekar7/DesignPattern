/*
    Heap (important data structure | Prims and DjKatras | timer implementation)
    -   not a sorted data structure
    -   heap is a complete binary tree
            -   left child of parent X is the node that : found in position (2x+1)
            -   right child of parent X is at position (2x+2)

            -   the parent of Y is at index :  (Y-1)/2


    -   Items are removed from the beginning of the queue
    -   logical ordering of objects is determined by their priority
    -   highest priority is at front of the Priority-Queue

    Heap data structure is an
        -   array of elements that can be observed as a complete binary tree

        -   The tree is a complete binary tree. A heap is a complete binary tree so
            the height of tree with N nodes is always O(log n)

        -   max-heap 
                -   parent’s value is greater than or equal to its children value. 
                -   largest-value element at the root. [8 5 7 4 1 6 3 2]
        -   min-heap
                -   parent’s value is less than or equal to its children value
                -   minimum-value element at the root. [1 2 3 4 5 6 7 8]
                -   whenever you need quick access to the smallest item

        Insert O(log n)
        DeleteMax O(log n)
        Remove O(log n)
        FindMax O(1)


        k
        small / large

        K + small = max
        K + large = min

        Complexity reduces from n Log n => n log k

*/ 