/*
    A Higher-Order Function (HOF) is a function that:
        ✅ Takes another function as an argument
        ✅ Returns another function
    Why Use HOFs?
        Encapsulate reusable logic
        Enhance code modularity & readability
        Enable functional programming patterns
    Example
        -   map, filter and reduce are all higher order functions
        -   Event Handling
            document.getElementById("btn").addEventListener("click", () => console.log("Clicked!"));



*/

//  Functions that take or return other functions.

    function higherOrder(fn) {
        return fn(5);
    }
    higherOrder((x) => x * 2); // 10

// 2 Callback Functions: Pass functions as arguments


function fetchData(callback) {
    setTimeout(() => {
        callback("Data loaded");
    }, 1000);
}
fetchData(console.log); // Logs after 1 second


//3 Closures - Inner functions that "remember" their outer scope.

function counter() {
    let count = 0;
    return function () {
        return ++count;
    };
}
const increment = counter();
console.log(increment()); // 1
console.log(increment()); // 2


// Function Scope
// 1 Block Scope: Variables declared with let or const are block-scoped.
{
    let x = 10;
    const y = 20;
    var z = 30;
}
console.log(z); // 30


// 2 Lexical Scope: Functions access variables defined in their outer scope

function outer() {
    const x = 10;
    return function inner() {
        console.log(x);
    };
}
outer()(); // 10


/*
    -   Function Context
        -   call, apply, and bind
        -   control this in a function
        -   call: Invoke immediately, pass arguments directly
        -   apply: Invoke immediately, pass arguments as an array.
        -   bind: Returns a new function with this bound.
 */

// call
function greet(greeting) {
    console.log(`${greeting}, ${this.name}`);
}
greet.call({ name: "Alice" }, "Hello"); // Hello, Alice
// call sets this to { name: "Alice" }
// immediate invoke

// apply
greet.apply({ name: "Alice" }, ["Hello"]); // Hello, Alice
// apply sets this to { name: "Alice" } but takes arg as array
// immediate invoke

// bind
const greetAlice = greet.bind({ name: "Alice" }, "Hello");
greetAlice(); // Hello, Alice
// Does not invoke the function immediately.
// Returns a new function with this permanently bound

// Pure Functions: 
const add = (a, b) => a + b;

// Currying: Functions without side effects.
const multiply = (a) => (b) => a * b;
console.log(multiply(2)(3)); // 6






