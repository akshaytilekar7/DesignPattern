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


}
