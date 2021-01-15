using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.CSharp
{
    public static class Extensions
    {
        public static bool IsLengthGreaterThanSpecifiedNumber<T>(this IEnumerable<T> enumerable, int number)
        {
            return enumerable.ToList().Count > number; // or Take(number).Count()
        }
    }

    // principle of encapsulation is not really being violated.
    // methods cannot access private variables in the type they are extending
    // cant override them
    // you can write a method having same signature but it will never call
    // as compile time, it has lowest priority then instance methods 
    //

}
