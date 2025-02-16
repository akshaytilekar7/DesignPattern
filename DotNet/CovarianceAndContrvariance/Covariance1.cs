using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContrvariance;

public class Covariance
{
    public void Example1()
    {
        IEnumerable<string> strings = new List<string> { "apple", "banana", "cherry" };

        // Covariance: IEnumerable<string> to IEnumerable<object>
        // use child where base was expeted
        IEnumerable<object> objects = strings; 

        foreach (var obj in objects)
            Console.WriteLine(obj); // Works because string is derived from object
    }

}
