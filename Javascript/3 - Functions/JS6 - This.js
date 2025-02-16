/*

-   this
    -   execution context of a function or object
    -   Its value depends on HOW THE FUNCTION IS CALLED.

    -   Global Scope
        -   global context (outside functions), this refers to the global object
        -   window for chrome and global for node
    -   Inside a Regular Function
        -   normal function, this refers to the global object (window)
            in non-strict mode
        -   in strict mode, this is undefined.
    -   Inside an Object
        -   Inside an object method, this refers to the object that owns the method.
    -   Arrow Functions:
        -   don't have their own this
        -   inherit this from the surrounding lexical scope.
        -   value of this inside the arrow function is not determined
            by how the function is called,
            but rather it is determined by the
            CONTEXT IN WHICH THE ARROW FUNCTION WAS CREATED
        -   THEY INHERIT THE THIS VALUE FROM THE SURROUNDING CONTEXT AT THE TIME THE FUNCTION WAS CREATED.
        -   this is lexically inherited from the outer context, which often causes confusion because it doesn’t behave the same way as in regular functions.
    -   Constructor Functions
        -   When a function is called with new, this refers to the new object created


*/

// Inside an Object example
const obj = {
    name: "John",
    greet: function () {
        console.log(this.name); // "John"
    },
};
obj.greet();



// Arrow funtion

const obj = {
    name: "John",
    greet: () => {
        console.log(this.name); // `undefined` because it uses the global `this`
    },
};


obj.greet();

// since greet is an arrow function inside the obj object, it takes this from the global context (outside the object) where this refers to the global object (window in browsers), which does not have a name property.




// Constructor Functions
function Person(name) {
    this.name = name;
}
const john = new Person("John");
console.log(john.name); // "John"

// see call apply and bind 
