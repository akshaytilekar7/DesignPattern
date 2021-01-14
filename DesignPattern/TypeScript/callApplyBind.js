/*

Function borrowing allows us to use the methods of one object on a different object 
without having to make a copy of that method and maintain it in two separate places. 
It is accomplished through the use of .call(), .apply(), or .bind()


 .bind()
    -   when you want that function to later be called with a certain context.
    -   useful in events.
    -   it returns a new function.
    -   creates a new function with a given this value, and returns that function without executing it.

.call()/.apply()
    -   want to invoke the function immediately, AND MODIFY THE CONTEXT.
    -   In simple term, attach function with specified object
    -   funcName.call(objectName, para1, para2 , ...)
    -   call a function with a given this value, and return the return value of that function.

    Call invokes the function and allows you to pass in arguments one by one.
    Apply invokes the function and allows you to pass in arguments as an array.
    Bind returns a new function, allowing you to pass in a this array and any number of arguments.

 */

var person1 = { firstName: 'Jon', lastName: 'Kuperman' };
var person2 = { firstName: 'Kelly', lastName: 'King' };

function say(strHi) {
    console.log(strHi + ' ' + this.firstName + ' ' + this.lastName);
}

// Call
say.call(person1, 'Hello'); // Hello Jon Kuperman
say.call(person2, 'Hello'); // Hello Kelly King

// apply
say.apply(person1, ['Hello']); // Hello Jon Kuperman
say.apply(person2, ['Hello']); // Hello Kelly King

//bind  [It returns a new function.]
var sayHelloJon = say.bind(person1);
var sayHelloKelly = say.bind(person2);

sayHelloJon('Hello'); // Hello Jon Kuperman
sayHelloKelly('Hello'); // Hello Kelly King

//______________________________________________________________

// spread - you are expanding a single variable into more
var abc = ['a', 'b', 'c'];
var def = ['d', 'e', 'f'];

var alpha = [...abc, ...def];

console.log(alpha); // alpha == ['a', 'b', 'c', 'd', 'e', 'f'];

//rest arguments, you are collapsing all remaining arguments of a function into one array:
function sum(first, ...others) {
    for (var i = 0; i < others.length; i++)
        first += others[i];
    return first;
}

console.log(sum(1, 2, 3, 4));// sum(1, 2, 3, 4) == 10;
