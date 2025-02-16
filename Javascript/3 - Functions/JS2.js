// FUNCTIONS IN JS

//Passing data to functions

/*
    -   pass by value 
        -   prmitice data types, original value remains unchanged
    -   pass by refereance
        -   array and object pass by refrance, changes reflected outside
    -   default parameter
        -   no restriction as traling default like C#
    -   rest parameter
    -   the argument object
    -   passing function as arguments

*/


// default parameter
function sum(a = 0, b, c = 0) {
    return a + b + c;
}
let x = sum(); // NaN   0 undefine 0
let x = sum(2); // NaN  2 undefine 0
let x = sum(1,1); //2   1 1 0 


/*
Argument object
    -   Avoid to use 'arguments' object and prefer Rest parameter

Rest parameter
    -   allow function to accept indefinate number of aruguments

*/

// Rest parameter
const displayFlights = function (...flights) {
    flights.forEach(f => {
        createFlightEntry(f.flight, f.from, f.status, f.color);
    });
}

displayFlights(
    { flight: 'RO12345', from: 'Paris', status: 'On time' },
    { flight: 'US67957', from: 'Berlin', status: 'On time' },
    { flight: 'AF89756', from: 'New York', status: 'Delayed', color: 'yellow' },
    { flight: 'UAL7897', from: 'Bucharest', status: 'Cancelled', color: 'red' },
    { flight: 'OS4782', from: 'Vienna', status: 'On time' }
);

// call back - passing function as parameter

const displayTime = () => {
    const time = new Date().toLocaleTimeString();
    document.getElementById('time').innerText = time;
}


displayTime();
setInterval(displayTime, 1000);
