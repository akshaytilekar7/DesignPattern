#region IEnumberableAdvanategOverList

using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.CSharp
{
    public class Demo1
    {
        public Demo1()
        {

            var names = new List<string> { "Akshay", "Akshata", "Yash", "Yashraj" };

            var startingWithA = names.Where(x => x.StartsWith("A"));

            var startingWithY = names.Where(x => x.StartsWith("Y"));

            // updating existing list
            names[0] = "Yamini";

            // Guess what should be printed before continuing
            Console.WriteLine(startingWithA.ToList());
            // expect : Akshay Akshata
            // actual : Akshay

            Console.WriteLine(startingWithY.ToList());
            // expect : Yash Yashraj
            // actual : Yash Yashraj Yamini
        }

    }
}

// Evaluation of the result was DEFERRED UNTIL CALLING TOLIST 

// IEnumerable where only create a query but not execute it
//  (behind the scenes the expression trees are used).

// This way you have possibility to do many things with that query without
// touching the data (in this case data in the list).

// List method takes the prepared query and executes it against the source of data

// IEnumerable is read-only and List is not.

// IEnumerable, you give the compiler a chance to defer work until later,
//  possibly optimizing along the way.

// If you use ToList() you force the compiler to reify the results right away.


// IEnumerable
// ICollection
// IList

#endregion


#region Find-Where().First()


/*

    Find is available only for the List<T>.
    Where is in IEnumerable

    Find() can be up to 1000% faster than using a Where with FirstOrDefault()

    FirstOrDefault() method always executes a query on the database.
    Find() method is more complicated. 
            At first it checks if required entity is already loaded into in memory database context. 
                If YES -  the result is returned without hitting the database. 
                If NO  -  query on the database is executed

*/

public class EF
{
    private static void FindVsFirstOrDefault()
    {
        // uncomment when reading
        //using (var context = new EFDb())
        //{
        //    // load add data having empId is less than 5 in memory
        //    context.Database.Log = (string msg) => { Console.WriteLine(msg); };
        //    var people = context.Employees.Where(p => p.empid <= 5).ToList();

        //    //asks database for a person using Primary Key
        //    Console.WriteLine("FirstOrDefault");
        //    var query1 = context.Employees.FirstOrDefault(p => p.empid == 1);
        //    //‘query1’ is sent to the database, despite the fact that the entity we are looking for already exists in context.

        //    //asks first the database context (in memory). Entity is already loaded, so it returns it without querying the database.
        //    Console.WriteLine("Find 1");
        //    var query2 = context.Employees.Find(1);
        //    //‘Query2’ is not sent to the database, because this entity already exists in our context. 


        //    //asks first the database context (in memory). Entity is not loaded yet, so it asks the database.
        //    Console.WriteLine("Find 6");
        //    var query3 = context.Employees.Find(6);
        //    //‘query3’ uses Find method, but required entity is not existing in our context yet, therefore query is sent to the database.

        //}
    }

}


#endregion
