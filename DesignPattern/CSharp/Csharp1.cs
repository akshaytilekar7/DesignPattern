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

== is the identity test. 
It will return true if the two objects being tested are in fact the same object. 

Equals() performs an equality test, and will return true 
if the two objects consider themselves equal.


Identity testing is faster,

*/

/*

read only and static and constants


constant
    -   Constants are static by default
    -   They must have a value at compilation-time (you can have e.g. 3.14 * 2, but cannot call methods)
    -   Can be used in attributes

Readonly instance fields
    -   Must have set value, by the time constructor exits
    -   Are evaluated when instance is created
    -   readonly for reference types only makes the reference read only not the values
    -   This value can only be changed in the constructor. Can't be changed in normal functions.


Static readonly fields
    -   evaluated when code execution hits class reference
    -   evaluated value by the time the static constructor is done
    -   


        object obj = 10;
		var v = obj. GetType();   //System.Int32

		object obj1 = "10";
		var v1 = obj1. GetType();  //System.String
*/