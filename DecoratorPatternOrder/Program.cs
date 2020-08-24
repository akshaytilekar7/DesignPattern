using DecoratorPatternOrder.ConcreteComponents;
using DecoratorPatternOrder.ConcreteDecorators;
using System;

namespace DecoratorPatternOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var regularOrder = new RegularOrder();
            Console.WriteLine(regularOrder.CalculateTotalOrderPrice());
            Console.WriteLine();

            var preOrder = new PreOrder();
            Console.WriteLine(preOrder.CalculateTotalOrderPrice());
            Console.WriteLine();

            var premiumPreOrder = new PremiumPreOrder(new PreOrder());
            Console.WriteLine(premiumPreOrder.CalculateTotalOrderPrice());

            Console.ReadKey();
        }
    }
}


// [A]
// regularOrder orders our products in a RegularOrder =>  ACTUAL PRICE;
// buyer orders our products in a preOrder =>  ACTUAL PRICE + 100;

// [B]
// premium users for the preOrder. =>  ACTUAL PRICE + 100 + 50;

/*
 [A] : we can create 2 classes "RegularOrder" & "PreOrder" for calculating discount

 [B] : we can write this logic : if statement to check if our user is a premium user,  
       but that would break the "Open Closed Principle"
       
 [B] : use decorator pattern :
        -   Decorator class which is going to wrap our Order object:
        -   Implement the PremiumPreOrder (Concrete Decorator) class:
            -   var preOrderPrice = base.CalculateTotalOrderPrice(); // logic for preOrder - existing call
            -   return preOrderPrice + 50;  // added new logic of [B]
        -   Call :  var premiumPreOrder = new PremiumPreOrder(new PreOrder());

 :  allows us to extend the behavior of objects by placing these objects into a special wrapper class.
 :  dynamically add behaviors to the wrapped objects.
 :  The structure of this pattern consists of a Component class and a Concrete Component class from one part 
    and a Decorator class and a Concrete Decorator class on the other side. 
    The Concrete Decorator class is going to add additional behavior to our Concrete Component.

 : USE WHEN : Need to add additional behavior to our objects (dynamically)

 [i] : in normal case if we have 3 combination and after that lets say 5 6 then we have to change existing behavior
        
 */
