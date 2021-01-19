/*

abstract method is implicitly a virtual method.
abstract method is always public.

abstract and interface

class allows you to create functionality that subclasses can implement or override
interface only allows you to define functionality, not implement it

class can extend only one abstract class, it can take advantage of multiple interfaces.
An abstract member cannot be static or private.
abstract method cannot be marked virtual

interface means a contract to interact with multiple code modules.
interface in WCF interfaces to define Service Contracts.

*/

/*

read only and static and constants

    constant
        -   constants are static by default
        -   They must have a value at compilation-time (you can have e.g. 3.14 * 2, but cannot call methods)
        -   Can be used in attributes
        -   we can access by className.ConstantPropertyName [IMP]

    Readonly instance fields
        -   Must have set value, by the time non-static constructor exits
        -   Are evaluated when instance is created
        -   readonly for reference types only makes the reference read only not the values
        -   This value can only be changed in the constructor. Can't be changed in normal functions.
        -   value can be changed again and again through a constructor.
        -   each object instance can have different value


    Static readonly fields
        -   assigned at runtime or assigned at compile time and changed at runtime
        -   only be changed in the static constructor [change only once at runtime]
        -   evaluated when code execution hits class reference
        -   evaluated value by the time the static constructor is done
        -   if it is un-initialize then default value of data type


        object obj = 10;
		var v = obj.GetType();   //System.Int32

		object obj1 = "10";
		var v1 = obj1. GetType();  //System.String
*/

/*

    Boxing 
        -   process of converting a value type to reference type
            [type object or to any interface type implemented by this value type]
        -   Boxing is implicit
        -   When the CLR boxes a value type, it wraps the value inside a System.Object instance 
            and stores it on the managed heap. 
        -   used to store value types in the garbage-collected heap
        -   Boxing a value type allocates an object instance on the heap 
            and copies the value into the new object.

    Unboxing
        -   Attempting to unbox null causes a NullReferenceException. 
        -   Attempting to unbox a reference to an incompatible value type causes an InvalidCastException.

    Enum
        -   numeric constants in .NET framework.
        -   value type
        -   type : integer, float, int, byte, double
        -   can have the same value in the enum type
        -   we cant add method in enum BUT => 
            to add functionality to an enumeration type, create an extension method.


*/

using System;

namespace DesignPattern.CSharp
{
    enum Duration { Day, Week, Month };

    static class EnumDurationExtensionsMethod
    {
        public static DateTime From(this Duration duration, DateTime dateTime)
        {
            switch (duration)
            {
                case Duration.Day: return dateTime.AddDays(1);
                case Duration.Week: return dateTime.AddDays(7);
                case Duration.Month: return dateTime.AddMonths(1);
                default: throw new ArgumentOutOfRangeException(nameof(duration));
            }
        }
    }
}


