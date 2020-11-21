/*
 .bind()
    -   when you want that function to later be called with a certain context, useful in events.
    -   It returns a new function.
    -   creates a new function with a given this value, and returns that function without executing it.

call()/.apply()
    -   want to invoke the function immediately, and modify the context.
    -   call a function with a given this value, and return the return value of that function.

    Call invokes the function and allows you to pass in arguments one by one.
    Apply invokes the function and allows you to pass in arguments as an array.
    Bind returns a new function, allowing you to pass in a this array and any number of arguments.

 */

var person1 = { firstName: 'Jon', lastName: 'Kuperman' };
var person2 = { firstName: 'Kelly', lastName: 'King' };

function say(greeting) {
    console.log(greeting + ' ' + this.firstName + ' ' + this.lastName);
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

sayHelloJon(); // Hello Jon Kuperman
sayHelloKelly(); // Hello Kelly King

______________________________________________________________

// spread - you are expanding a single variable into more
var abc = ['a', 'b', 'c'];
var def = ['d', 'e', 'f'];
var alpha = [...abc, ...def];
console.log(alpha)// alpha == ['a', 'b', 'c', 'd', 'e', 'f'];

//rest arguments, you are collapsing all remaining arguments of a function into one array:
function sum(first, ...others) {
    for (var i = 0; i < others.length; i++)
        first += others[i];
    return first;
}
console.log(sum(1, 2, 3, 4))// sum(1, 2, 3, 4) == 10;
