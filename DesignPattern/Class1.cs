// Abstract Product
using System;
using System.Collections.Generic;

public class Application
{
    public class MixedDataComparer : IComparer<object>
    {
        public int Compare(object x, object y)
        {
            if (x == null || y == null)
                return 0; // Treat nulls as equal

            if (x is int intX && y is int intY)
                return intX.CompareTo(intY);

            if (x is DateTime dtX && y is DateTime dtY)
                return dtX.CompareTo(dtY);

            if (x is string strX && y is string strY)
                return strX.CompareTo(strY);

            // Handle string-to-number comparison
            //if (x is string strNumX && int.TryParse(strNumX, out int parsedX))
            //    return parsedX.CompareTo(y);

            //if (y is string strNumY && int.TryParse(strNumY, out int parsedY))
            //    return parsedY.CompareTo(x);

            // Default to string comparison
            return x.ToString().CompareTo(y.ToString());
        }
    }

    public static void Main(string[] args)
    {

        var list = new List<object> { 10, "5", DateTime.Now, "hello", 3, "2023-01-01" };

        foreach (var item in list)
            Console.Write(item + " ");
        
        Console.WriteLine("");

        list.Sort(new MixedDataComparer());

        foreach (var item in list)
            Console.Write(item + " ");

        Console.WriteLine("");
        Console.ReadLine(); 
    }
}
