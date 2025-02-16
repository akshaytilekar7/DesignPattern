/*

Objects
    -   Objects are dynamic collections of properties
        where each property is a key-value pair.
    -   Serve foundation of JavaScript's prototype-based inheritance

*/

// Ways to Create Object 

//  1.  Object Literals
const obj = {
    key: "value",
    method() {
        return this.key;
    }
};

//  2.  Constructor Functions
function Person(name) { this.name = name; }
const p = new Person("Pooja");

// 3.   Object.create() (Prototype-based instantiation):
const base = {
    greet() {
        return "Hello";
    }
};
const derived = Object.create(base);


// 4 ES 6 syntax
class Person {
    constructor(name) { this.name = name; }
}
const p2 = new Person("Bob");


// 5 Object.assign(target, source)
// Copying properties from one object to another.

const obj1 = { a: 1 };
const obj2 = Object.assign({}, obj1, { b: 2 });
