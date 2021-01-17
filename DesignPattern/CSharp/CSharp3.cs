using System;
using System.Collections.Generic;

/*
    Indexer [smart arrays]
        -   allow instances of a class/struct to be indexed just like arrays
        -   created using this keyword
        -   indexers do not have to be indexed by an integer value; 
            it is up to you how to define the specific look-up mechanism.
        -   can be overloaded.
        -   class property that allows you to access a member variable of a class using 
            the features of an array

 
    <modifier> <return type> this [argument list]  
    {  
        get { // your get block code }  
        set { // your set block code }  
    }  

*/


namespace DesignPattern.CSharp
{
    class StringDataStore
    {
        private readonly string[] strArr = new string[10]; // internal data storage

        // int type indexer
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= strArr.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                return strArr[index];
            }

            set
            {
                if (index < 0 || index >= strArr.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                strArr[index] = value;
            }
        }

        // string type indexer
        public string this[string name]
        {
            get
            {
                foreach (string str in strArr)
                {
                    if (str.ToLower() == name.ToLower())
                        return str;
                }

                return null;
            }
            set => strArr[0] = value;
        }
    }

    class Program12
    {
        static void Main1(string[] args)
        {
            StringDataStore strStore = new StringDataStore { [0] = "One", [1] = "Two", [2] = "Three", [3] = "Four" };


            Console.WriteLine(strStore["one"]);
            Console.WriteLine(strStore["two"]);
            Console.WriteLine(strStore["Three"]);
            Console.WriteLine(strStore["Four"]);
            strStore["one"] = "A"; // because on string indexer "set"
        }
    }
}


/*
 Covariance 
 and contra-variance [4.0]

        [List<T> coz : we can add type T or its subtype] 
        [means we can use "more derived type"]
        [use a derived class where a base class is expected]
        [only for mutable objects] 
    -   refer to how you treat an object
    -   Covariance preserves assignment compatibility and contra-variance reverses it.

    -   Immutable collection classes like lists are covariant
        when you are only allowed to push elements in if they are of type T or its subtype. 
    -   covariance comes into picture when you are working with mutable [liable to change] collections.

    -   Contra-variance allows you to utilize a less derived type than originally specified,
    -   covariance -  child can use instead of parent
                   -  method returns a more specific type.
    -   contra-variance 
                    -   method is passed a less specific type [parent can pass]
*/

public class Co
{
    public Co()
    {
        // Covariance.
        IEnumerable<string> strings = new List<string>();
        // An object that is instantiated with a more derived type argument
        // is assigned to an object instantiated with a less derived type argument.
        // Assignment compatibility is preserved.
        IEnumerable<object> objects = strings;

        // Contra-variance.
        IEnumerable<object> objects2 = new List<object>();
        //IEnumerable<string> strings2 = objects2;

    }
}