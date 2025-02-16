/*

 JS - loosly type prototype based language
 Object Oriented Concept in JS
    -   
*/

// Prototype internal working

let Person = {
    firstName: '',
    lastName: '',
    agetName: '',
    fullName() {
        return this.firstName + " " + this.lastName;
    }
};

let jim = { firstName: "A", lastName: "B", last: "C" };
Object.setPrototypeOf(jim, Person);

console.log(jim.age); // 0
console.log(jim.fullName()); //A B
console.log(jim.last); // C

console.log(Person.hasOwnProperty('age')); // True
console.log(jim.age); // 0 

console.log(jim.hasOwnProperty('age')); // false still we can acccess ahe from JIM How?
// coz property inherite from protoype arent actually copied to child object
// instead wehn accesssing porp or methods on an object
// JS will not look into Object itslef but also its prototype

// jS look age prop on Jim object not founf then goto its prototype
// if same name added in object then JS ovverides and get value from object not from prototype

// create multiple levals using prototype chain
// all object inherit from prototype Object



/*
A pure function is a function that:
    ✅ Always returns the same output for the same input.
    ✅ Has no side effects(doesn’t modify external variables, doesn’t change DOM, doesn’t log, etc.).

Event Bubbling
     Event Bubbling is a behavior where an event first triggers on the target element and
        then propagates (bubbles) up to its parent elements.
     event.stopPropagation().


TODO;
    Mixins & Composition vs Inheritance  



*/