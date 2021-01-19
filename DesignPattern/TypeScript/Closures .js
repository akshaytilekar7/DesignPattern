
/*
    class Foo { }
    typeof Foo // 'function'

Closure
    -   when function access and remember its lexical scope 
        even when function is executed outside its lexical scope
    -   inner function always has access to the vars and parameters of its outer function, 
        even after the outer function has returned
    -   means it maintain its lexical scope (compile time scope)
    -   closure is a function bundled with its lexical scope
    -   created at runtime during function creation

    Use
    -   enable data privacy
    -   helps for "program to an interface, not an implementation"

 */

function OuterFunction() {

    var outerVariable = 100;

    function innerFunction() {
        console.log(outerVariable);
    }

    return innerFunction;
}

var innerFunc = OuterFunction();
innerFunc(); // 100


/*
    curried function
        -   function that TAKES MULTIPLE ARGUMENTS ONE AT A TIME.
            function with 3 parameters, the curried version will take one argument and 
            return a function that takes the next argument, 
            which returns a function that takes the third argument

*/

const add = a => b => a + b;
add(5)(3);

var f = function (a) {
    return function (b) {
        return a + b;
    }
}

f(15)(3);


/*
    Q.  undefined and "undefined"

        undefined is actually window.undefined in most situations. It's just a variable.
        window.undefined happens to not be defined, unless someone defines it (try undefined = 1 and typeof undefined will be "number").
        typeof is an operator that always returns a string, describing the type of a value.
        typeof window.undefined gives you "undefined" - again, just a string.
        typeof "undefined" gives "string", just like typeof "foo" would.
        Therefore, typeof typeof undefined gives "string".

    Q.  difference between a variable that is: null, undefined or undeclared?

        undefined   -   variable that has been declared but not assign any value
                        and is a type of itself ‘undefined’.
                        undefined is not a keyword.

                        var geek;
                        console.log(geek) // undefined

        null        -   is a value of a variable and is a type of object
                        console.log(myVariable) //ReferenceError: myVariable is not defined.
                        'use strict' so no undeclared variable is present if exist


        JS is complied language
            but not convert into any byte code or machine code

    Q.  difference between function expression and function declaration

        FUNCTION EXPRESSION  (Never Hoisted)         ||      FUNCTION DECLARATION
                                                     ||
        // TypeError: functionOne is not a function  ||     // Outputs: "Hello!"
        x();                                         ||     y();
                                                     ||
        var x = function() {                         ||     function y() {
          console.log("Hello!");                     ||       console.log("Hello!");
        };                                           ||     }




    Q.  let, const and var
        -   var declarations are globally/function scoped while let and const are block scoped.
        -   var variables can be updated and re-declared within its scope;
            let variables can be updated but not re-declared;
            const variables can neither be updated nor re-declared.

        -   all hoisted to the top of their scope.

            LET AND CONST HOIST BUT YOU CANNOT ACCESS THEM BEFORE 
            THE ACTUAL DECLARATION IS EVALUATED AT RUNTIME.

            var variables are initialized with undefined,
            let and const variables are not initialized
      
        -   var and let can be declared without being initialized,
            const must be initialized during declaration.
    
        -   var : function scope
            let : block scope


        Ex :
            No error                ||    SyntaxError: Identifier 'x' has already been declared
                                    ||
            function x(){           ||     function y(){
             var x = 5;             ||      let x = 5;
             console.log(x)         ||      console.log(x)
                                    ||
             var x = "Ted";         ||      let x = "Ted";
             console.log(x)         ||      console.log(x)
            }                       ||     }


        Ex:

        function x(){                           ||     function x1(){
         console.log(z);                        ||      console.log(z1);
         var z = 10;                            ||      let z1 = 10;
        }                                       ||     }
                                                ||
        x() // undefined                        ||     x1()
            // only declaration hoisted         ||     //ReferenceError: Cannot access 'z1' before initialization




    Q.  Hoisting
        -   function and variable DECLARATION moves to top
        -   function expression (ie, var x = function(){} ) never get hoisted


    Q.  this
        every function while executing has reference to its current context

    Q.  immutability / freeze

    var x = 6;
    x++ // 6

    const x1 = 6;
    x1++ // error : Assignment to constant variable

    _________________________________________________

    const arr = [1,2,3]

    arr = 9; //   Uncaught TypeError: Assignment to constant variable.

    arr[0] = 50; // [50, 2, 3]

    _________________________________________________

    const arr3  = Object.freeze([1,2,3])
    arr3[0] = 100; // no error no update
    [1, 2, 3]


 */
