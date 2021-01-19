using System;
using System.Collections;
using System.Collections.Generic;

/*
    SortedList
    Enumerable
    Collection
    List

    jagged array 
    multidimensional array

    HashTable
    Tuple Class
    EqualAnd==
*/
namespace DesignPattern.CSharp
{
    class CSharp2
    {
        public CSharp2()
        {
            //primitive type keys in ascending order and object keys based on IComparer<T>.
            //It uses less memory than SortedDictionary<TKey, TValue>.
            //It is faster in the retrieval of data once sorted,
            //whereas SortedDictionary<TKey, TValue> is faster in insertion
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

Enumerable - access items, unordered, unmodifiable ie readonly
Collection - can be modified (add,delete,count)
List - allows items to have an order (accessing and removing by index) and can access by index

    Enumerable has no order. 
        No add or remove functionality
        No count() functionality 
        It strictly lets you access each item in the set, one after the other.

    Collection is a modifiable set. 
        can add or remove 
        have count of items functionality
        but no order, and because there is no order: no way to access an item by index,
            nor is there any way to sort.

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
        Insert (add at specified index)
        IndexOf
        RemoveAt

    means
    List has more methods then ICollection
    LinkList    -   cant allowed by index


*/

/*

    jagged array [individual can be of different lengths]
        -   is an array-of-arrays, so an int[][] 
            is an array of int[],  each of which can be of different lengths and
            occupy their own block in memory. 
        -   Error for int[][] arr = new int[10][20];
            because each sub-array HAS TO BE initialized separately, 
                as they are separate objects


    multidimensional array (int[,]) 
        -   is a single block of memory (essentially a matrix).
        -   int[10,20] is ok, because it is initializing a single object as
            a matrix with 10 rows and 20 columns.

 */

/*

HashTable [Non generic version]:
    -   collection of key/value pairs that are ORGANIZED BASED ON THE HASH CODE OF THE KEY.
    -   MSDN Don't recommend that you use the Hashtable class for 
        new development instead use Dictionary<TKey,TValue>
    -   need to override the Object.GetHashCode and  Object.Equals for IComparer
    -   both methods and interfaces must handle case sensitivity the same way; 
        otherwise, the Hashtable might behave incorrectly.
    -   When an element is added to the Hashtable, THE ELEMENT IS PLACED INTO A BUCKET BASED ON 
        THE HASH CODE OF THE KEY. Subsequent lookups of the key use the hash code of the key
        to search in only one particular bucket, thus substantially reducing the number of key 
        comparisons required to find an element.
*/

public class Ht
{
    public Ht()
    {
        Hashtable openWith = new Hashtable();
        openWith.Add("bmp", "paint.exe"); // object , object
        foreach (DictionaryEntry de in openWith)
        {
            Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
        }
    }
}

/*

    Dictionary<TKey,TValue> []
        -   Represents a collection of keys and values
        -   Retrieving a value by using its key is very fast, 
            close to O(1), because the Dictionary<TKey,TValue> 
        -   class is implemented as a hash table.


*/

public class Di
{
    public Di()
    {

        Dictionary<string, string> openWith = new Dictionary<string, string>();
        openWith.Add("txt", "notepad.exe");
        foreach (KeyValuePair<string, string> kvp in openWith)
        {
            Console.WriteLine("Key = {0}, Value = {1}",
                kvp.Key, kvp.Value);
        }
    }
}

/*

    Tuple Class [TO REPRESENT A SINGLE SET OF DATA]
    -   data structure that has a specific number and sequence of elements
    -   store an identifier such as a 
        name    :   1st ele 
        DOB     :   2nd ele        
        income  :   3rd ele
    -   directly supports tuples with one to seven elements
    -   In addition, you can create tuples of eight or more elements by nesting tuple objects 
        in the Rest property of a Tuple<T1,T2,T3,T4,T5,T6,T7,TRest> object.

    -   Use
    -   TO REPRESENT A SINGLE SET OF DATA. For example, a tuple can represent a database record, 
        and its components can represent individual fields of the record.
    -   To provide easy access to, and manipulation of, a data set.
    -   To return multiple values from a method without using out parameters (in C#) 
    -   To pass multiple values to a method through a single parameter

    -   Tuple class does not itself represent a tuple. Instead, 
        it is a class that provides static methods for creating instances of the tuple types 
    -   most common use cases of tuples is as a method return type 
        :   (int min, int max) FindMinMax(int[] input) means -> syntax returnType Name(para)
    
*/


public class T1
{
    #region Tuple

    public T1()
    {
        var primes = Tuple.Create(2, 3, 5, 7, 11, 13, 17, 19);
        Console.WriteLine("Prime numbers less than 20: " +
                          "{0}, {1}, {2}, {3}, {4}, {5}, {6}, and {7}",
                          primes.Item1, primes.Item2, primes.Item3,
                          primes.Item4, primes.Item5, primes.Item6,
                          primes.Item7, primes.Rest.Item1);

        // 8 tuples
        Tuple<int, int, int> from_8_To_10 = Tuple.Create(8, 9, 10);

        var from_1_To_10 = new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int>>
            (1, 2, 3, 4, 5, 6, 7, from_8_To_10);

        var newTuples = new Tuple<string, int, int, int, int, int, int,
            Tuple<int, int, int, int, int, int, int, Tuple<int, int, int>>>
            ("Detroit", 1860, 45619, 79577, 116340, 205876, 285704, from_1_To_10);

        //access : newTuples.Rest.Item3

    }

    #region method return type

    (int min, int max) FindMinMax(int[] input)
    {
        return (5, 15);
    }

    public T1(int x)
    {
        var xs = new[] { 4, 7, 9 };
        var limits = FindMinMax(xs);
        var res1 = limits.max;
        var res2 = limits.min;

        var ys = new[] { -9, 0, 67, 100 };
        var (minimum, maximum) = FindMinMax(ys);
        var res11 = minimum;
        var res22 = maximum;
    }

    #endregion

    #region Tuple field names
    public T1(string s)
    {
        var t = (Sum: 4.5, Count: 3);
        var r1 = t.Count;
        var t2 = t.Sum;

        (double Sum1, int Count) = (4.5, 3);
        var r11 = Sum1;
        var t22 = Count;

        // another one
        var sum = 4.5;
        var Item3 = 3;
        var t1 = (sum, Item3);
        var x1 = t1.sum;
        var x2 = t1.Item2; // not item 3 because 

        /*
         That's known as tuple projection initializer. 
         The name of a variable isn't projected onto a tuple field name in the following cases:
            1   The candidate name is a member name of a tuple type, 
                for example, Item3, ToString, or Rest.
            2.  The candidate name is a duplicate of another tuple field
                name, either explicit or implicit.
            3.  In those cases you either explicitly specify the name 
                of a field or access a field by its default name.
            Default names of tuple fields are Item1, Item2, Item3 and so on.

         */
    }
    #endregion

    #endregion

    #region EqualAnd==

    /*
        == : object reference
        Equals : content are same

        and for string : always content comparision

    */
    public T1(double d)
    {
        object name = "John";
        object myName = new string("John".ToCharArray());

        Console.WriteLine(name == myName);  // False //  compares the reference identity
        Console.WriteLine(myName.Equals(name)); // True  // compares the contents of the objects

        /*
         // see reference are different
        
         Stack          Heap 

         name  ------->  "John"

         myName ------>  "John"

         */
    }

    public T1(double d, int c)
    {
        string name = "John";
        string myName = null;
        Console.WriteLine(name == myName);    //  compares the reference identity
        Console.WriteLine(myName.Equals(name));  // compares the contents of the objects

        Console.WriteLine(2 == 2.0); // true
        Console.WriteLine(2.Equals(2.0)); // true

        // Note in case of null
        // Equals() method is an extension method of the string 
        // so Equals() method then gets an exception of a null reference
    }
    #endregion

}