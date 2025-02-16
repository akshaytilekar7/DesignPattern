/*

-   call apply bind
    -   Methods defined on the Function prototype used to invoke functions
    -   You can provide the value for the this binding
*/

const printModel = function () {
    console.log(this.model);
};
printModel(); // undefined

const workingPrintModel = printModel.bind({ model: 'A380' });
workingPrintModel();


/*
    bind()
        -   creates a new function that has its 'this' set to the provided value
        -   Function.prototype.bind(thisObj)
            Function.prototype.bind(thisObj, arg1, arg2…)
*/



/*
    call()
    -   A function that can change the value of 'this' when invoking a function
    -   Function.prototype.call(thisObj)
        Function.prototype.call(thisObj, args1, args2, ...)
*/
const aircraft = {
    model: 'Airbus A330', totalSeats: 350, seatsOccupied: 100
}

const addPassengers = function (nbPassengers) {
    const newCount = this.seatsOccupied + nbPassengers;
    if (newCount <= this.totalSeats) {
        this.   = newCount;
    }
};

addPassengers(3); // seatsOccupied: 100
addPassengers.call(aircraft, 3); // seatsOccupied: 103


/*
 apply()
    -   Very similar to call()
    -   Can pass an array as an argument list instead of using a rest parameter for arguments
    -   Function.prototype.apply(thisObj)
        Function.prototype.apply(thisObj, [arg1, arg2…])
*/

const aircraft = {
    model: 'Airbus A330', totalSeats: 350, seatsOccupied: 100
};

const addPassengers = function (nbPassengers) {
    const newCount = this.seatsOccupied + nbPassengers;
    if (newCount <= this.totalSeats) { this.seatsOccupied = newCount; }
};
addPassengers.apply(aircraft, [3]); // seatsOccupied: 103


/*

The 'this' object takes many shapes in JavaScript

In a simplified way it usually refers to the object who is invoking the function

Arrow function inherit the “this” binding
from their parent scope

You can control the value of “this” by using
the bind(), call() and apply() methods

*/


// bind

function printAircraftInfo(message) {
    console.log(`${message}: ${this.make}, ${this.capacity}`);
}

printAircraftInfo('Aircraft summary');
const boundPrint = printAircraftInfo.bind({ make: 'Airbus A380', capacity: 500 });
boundPrint('Aircraft summary');

// call and bind

function alertPassenger(name) {
    console.log(`${name}: ${this.message}`);
}

const presentToGateWarning = { message: 'Please present to boarding gate 3', priority: 1 }

alertPassenger.call(presentToGateWarning, 'John Doe');

const alertJohnDoe = alertPassenger.bind(presentToGateWarning, 'John Doe');
alertJohnDoe();

// more read
