/*
     Ways to defined functions
    -   function declaration : fun f() {}
        -   Named functions that are hoisted meaning can invoked before they are declared
    -   function expression
        -   assign to variable and NOT HOISTED
    -   arrow function
        -   alternative to function expression with some limitations
        -   not hoisted
        -   can not be used as 
                -   constructor functions ie new arrowFunName(25.24);
                -   the argument object
                -   IMP - they dont have own "this" binding
    -   function constructor
        -   allows you to create functions dynamically as objects
        -   it parses the function body as a string at runtime, 
            making it less common but occasionally useful for dynamic scenarios.
        -   new Function([arg1, arg2, ...argN], functionBody);
    -   IIFE - immediatly invoked function expression
        -   Auto executes when declaration
        -   It allows you to execute code in a separate scope, avoiding polluting the global namespace.
        -   only body in important and mandetory for functions
            all other things such as Name, Parameter and return statement are optional

*/

// 1. Function Declaration
// Named function for reuse, hoisted in scope. (can be called before declaration)

function greet(name) {
    return `Hello, ${name}`;
}

// 2 Function Expression
// Assign function to a variable (anonymous or named).
// Not hoisted, useful for dynamic function assignment

const greet = function (name) {
    return `Hello, ${name}`;
};


// 3. Arrow Functions(=> )
// Shorter syntax, no own this, no arguments object.
// useful in event handlers
const convertToLiters2 = gallons => {
    return gallons * 3.785;
};
const convertToLiters1 = gallons => gallons * 3.785;
console.log(convertToLiters(10));

// limitations 1 - arrow fun can not used as constructor function
var x = new convertToLiters1(25.24);
// error convertToLiters1 is not ctor use fun declaration and expression file

// limitations 2 - arrow fun can not access arguments object
let sum = () => {
    for (var i = 0; i < arguments.lenght; i++) { // error here
        // do something
    }
}

// 4. Immediately Invoked Function Expression(IIFE)
// Runs immediately after definition, avoids polluting global scope.
// Why? Useful for encapsulating private variables & avoiding global scope pollution.

(function PrintDate() {
    let current = new Date().toLocaleString();
    console.log(current)
})();
// or
(function () {
    let current = new Date().toLocaleString();
    console.log(current)
})();

// or
(() => {
    // Code here
})();


// 5 Generator Functions
// Pause & resume execution using yield
// Why ? Efficient for handling large data sets & implementing iterators.

function* generateNumbers() {
    yield 1;
    yield 2;
    yield 3;
}
const gen = generateNumbers();
console.log(gen.next().value); // 1


// 6 Async Functions(async function)
// Work with Promises using await.
// Why? Simplifies asynchronous code, avoids callback hell.
async function fetchData() {
    const response = await fetch("https://api.example.com/data");
    return response.json();
}

// 7. Constructor Functions (new Function())
// Purpose: Creates dynamic functions at runtime (Not recommended).
// Why? Less efficient, hard to debug, no closure support.

const add = new Function("a", "b", "return a + b");
console.log(add(2, 3)); // 5











