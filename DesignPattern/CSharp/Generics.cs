/*
Generics

design interfaces and generic classes that have the same implementation, regardless of the type of parameter, increasing the flexibility of use in a safe way
we apply constraints to generics using “where” keyword.Constraints will result in compile time error if you instantiate with placeholder that is not defined in constraints.

*/

//Declaring multiple Generic with single & multiple class names using interface

class ModelExample3 { }
interface IModelExample { }

class Test
{
    public static void MultipleGenericExample1<T1, T2>(T1 t1, T2 t2) where T1 : ModelExample3, new() where T2 : IModelExample
    {
        //Console.WriteLine(String.Format("T1 Attributes {0}  {1}", t1.attribute1, t1.attribute2));
        //Console.WriteLine(String.Format("T2 Attributes {0}  {1}", t2.attribute1, t2.attribute2));
    }
}

