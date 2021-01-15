using System;
/*
    Indexer
        -   allow instances of a class or struct to be indexed just like arrays
        -   created using this keyword
        -   indexers do not have to be indexed by an integer value; it is up to you how to define the specific look-up mechanism.
        -   can be overloaded.
        -   smart arrays
        -   class property that allows you to access a member variable of a class using the features of an array

 
    <modifier> <return type> this [argument list]  
    {  
        get  
        {  
            // your get block code  
        }  
        set  
        {  
            // your set block code  
        }  
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
