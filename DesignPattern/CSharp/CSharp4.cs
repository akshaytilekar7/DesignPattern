using System.Collections.Generic;

namespace DesignPattern.CSharp
{
    class CSharp4
    {
        public CSharp4()
        {
            //primitive type keys in ascending order and object keys based on IComparer<T>.
            //It uses less memory than SortedDictionary<TKey, TValue>.
            //It is faster in the retrieval of data once sorted, whereas SortedDictionary<TKey, TValue> is faster in insertion
            //and removing key-value pairs.
            var lst = new SortedList<int, string>
            {
                {3, "Three"},
                {1, "One"},
                {2, "Two"},
                {4, null},
                {10, "Ten"},
                {5, "Five"}
            };

            // The following will throw exceptions
            // numberNames.Add("Three", 3); //Compile-time error: key must be int type
            // numberNames.Add(1, "One"); //Run-time exception: duplicate key
            // numberNames.Add(null, "Five");//Run-time exception: key cannot be null
        }
    }
}
/*

Enumerable - access items, unordered, unmodifiable
Collection - can be modified (add,delete,count)
List - allows items to have an order (accessing and removing by index) and can access by index

    Enumerable has no order. 
    You cannot add or remove items from the set. 
    You cannot even get a count of items in the set. 
    It strictly lets you access each item in the set, one after the other.

    Collection is a modifiable set. 
    You can add and remove objects from the set,
    you can also get the count of items in the set. 
    But there still is no order, and because there is no order: no way to access an item by index, nor is there any way to sort.

    List is an ordered set of objects. 
    You can sort the list, 
    access items by index, remove items by index.


    In fact, when looking at the interfaces for these, they build on one another:

    interface IEnumerable<T>
        GetEnumeration<T>
    
    interface ICollection<T> : IEnumerable<T>
        Add
        Remove
        Clear
        Count
    
    interface IList<T> = ICollection<T>
        Insert
        IndexOf
        RemoveAt

    means
    List has more methods then ICollection


    LinkList    -   cant allowed by index


*/

/*

    jagged array 
        -   is an array-of-arrays, so an int[][] 
            is an array of int[],  each of which can be of different lengths and
            occupy their own block in memory. 
        -   MyClass[10][20] because each sub-array has to be initialized separately, as they are separate objects


    multidimensional array (int[,]) 
        -   is a single block of memory (essentially a matrix).
        -   MyClass[10,20] is ok, because it is initializing a single object as a matrix with 10 rows and 20 columns.

 */
