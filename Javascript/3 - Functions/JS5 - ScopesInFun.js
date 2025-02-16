// SCOPES IN FUNCTIONS
/*

Scope
    -   The place (execution context) where variables and expressions are visible 
        (can be referenced)
    -   Global 
        -   A variable defined outside a function is a global variable
            All functions and scripts on that web page can access it
    -   Function / Local 
        -   Each function has its own scope
        -   Variables declared inside a function are not visible outside the function
        -   function can still access variables defined in its outer scope
    -   Block
        -   Introduced in ES6
        -   Applies to variables declared using 'let' and 'const'
        -   Variables defined within a block, denoted with { } are only 
            accessible in that block
*/

let appName = "Cool app"; // Global scope
{
    const aircraftModel = 'A380';
}
console.log(aircraftModel); // aircraftModel is not defined
for (let i = 0; i < 10; i++) {
    console.log(i);
}
console.log(i); // i is not defined


//functions scopes

const airportAltitude = 100;
function land() {
    let currentAltitude = 2000;
    let altDiff = currentAltitude - airportAltitude;
    // logic to land
}
console.log(currentAltitude); // Not defined

/*
Closure
    -   closure can access variables from its parent scope, even when invoked outside that scope.
    -   A CLOSURE IS THE COMBINATION OF A FUNCTION AND THE LEXICAL ENVIRONMENT 
        within which that function was declared
    -   This environment consists of any local variables that were in-scope at the time the closure was
        created. – MDN Docs
    -   Imagine you have an inner function defined in an outer function.
        A closure is a JavaScript feature in which the  
        inner function has access to the variables of the outer function…
        …EVEN AFTER THE OUTER FUNCTION HAS RETURNED.
    -   This environment consists of any local variables that were in -scope at the time the closure was
created
    -   same can achive with classes after ES 6
*/

// Closure Explained
function parent() {
    let name = 'John Doe'; // variable in outer function
    function child() {
        console.log(name);
    }
    return child;
}
let child = parent(); // outer function exited
child(); // John Doe

// when we create function child JS created colsoure for child()
// and that exceution context capture all variables that child can access
// Implementing Function Closure

//  Scope represents the execution context
//  where variables are visible
//  Global scope
//  Function scope
//  Block scope
//  Closure is the combination of a function bundled together with reference to its
//          surrounding variables and statements

// Uncomment the relevant sections to see how they behave

let maxAltitudeMeters = 10000;
console.log(maxAltitudeMeters);

const changeAltitude = (altitudeMeters) => {
    let minAltitudeMeters = 0;  // local variable

    if (altitudeMeters < maxAltitudeMeters &&
        altitudeMeters > minAltitudeMeters) {
        console.log(`Changing altitude to ${altitudeMeters}`);
        return;
    }
    console.log('Can not change altitude: out of bounds');
}

console.log(changeAltitude(5000));

// closure
let add;

(initFlight = () => {
  let nbPassengers = 100;

  const addPassenger = () => {
    nbPassengers++;
    console.log(nbPassengers);
  };

  add = addPassenger;
})();

add(); // 101
add(); // 102
add(); // 103
add(); // 104

 
