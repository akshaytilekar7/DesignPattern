/*
    this 
        -   not refer to the function in which it is used or it’s scope 
            but is determined mostly by the INVOCATION CONTEXT OF FUNCTION (context.function()) 
            and where it is called

            default binding
            implicit binding
            explicit binding
            new binding
*/

function foo() {
    var a = 2;
    this.bar();
}

function bar() {
    console.log(this.a);
}

foo();   //undefined


// 1 default binding
var myFunction = function () {
    console.log(this);
}
myFunction();    // Window

//because we call myFunction() from the Window context so this will refer to Window object .

var myFunction = function () {
    console.log(this.a);
}

var a = 5;
myFunction();    //5  
//defined the variable a in the window context so the output of the myFunction()
//call will be 5 because this will refer to window context which it’s the default context.



//2- Implicit Binding:
// Object that is standing before the dot is what this keyword will be bound to.

// EX
function foo() {
    console.log(this.a);
}

var obj = {
    a: 2,
    foo: foo
};

obj.foo();  // 2 
//this refer to  object obj
//so the value of this.a will equal 2.

// EX
var john = {
    name: 'John',
    greet: function (person) {
        console.log("Hi " + person + ", my name is " + this.name);
    }
}

john.greet("Mark");  // Hi Mark, my name is John
//this is refer to the john object so this.name will be John

var fx = john.greet;
fx("Mark");   // Hi Mark, my name is  
// fx will be a reference to the greet function itself 
// and default binding applies and this will refer to Window.


// 3- Explicit Binding:

// force a function call to use a particular object for THIS binding
// by using :  call, apply and bind

function greet() {
    console.log(this.name);
}

var person = {
    name: 'Alex'
}

greet.call(person, arg1, arg2, arg3, ...); // Alex
greet.apply(person, [args]); // Alex


// bind function creates a new function that will act as the original function BUT WITH THIS PREDEFINED.
var greetPerson = greet.bind(person);

greetPerson(); // Alex
window.greetPerson(); // Alex

// Now greetPerson function is a copy of greet BUT THIS WILL REFER TO THE PERSON OBJECT.

// BIND TO RETURNS A FUNCTION THAT YOU CAN LATER EXECUTE, 
// but Call / apply use it when you need to call the function immediately.

//4- New Binding

//  The function that is called with new operator when the code new Foo(…) is executed,
//  the following things happen:

/*

    1   -   An empty object is created and referenced by this variable, 
            inheriting the prototype of the function.
    2   -   Properties and methods are added to the object referenced by this.
    3   -   The newly created object referenced by this is returned at the end 
            implicitly (if no other object was returned explicitly).

 */

function Foo() {
    /*
       1- create a new object using the object literal 
       var this = {};
   */

    // 2- add properties and methods 
    this.name = 'Ted';
    this.say = function () {
        return "I am " + this.name;
    };

    // 3- return this;
}

var name = 'Ahmed';
var result = new Foo();
console.log(result.name);  //3 

//  By calling Foo() with new in front of it, we’ve constructed a new object 
//  and set that new object as the this for the call of foo().

//Priority
// The highest priority has new Binding.
// Then explicit binding and implicit binding.
// The lowest priority has default binding.

