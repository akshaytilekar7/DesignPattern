function Person(name, age) {
    this.name = name;
    this.age = age;
    var sal = 10;
};

function Student(name, age) {
    var name1 = name;
    age1 = age;
};

var p1 = new Person('Ted', 10); // undefined
// p1 // Person { name: "Ted", age: 10 }   // IMP

var s1 = new Student('Ted', 10);
// s1  Student { }  // IMP

/*
Object.assign() 
    copies the values from one or more source objects to a target object.
*/

let a = Object.assign({ foo: 0 }, { bar: 1 }, { baz: 2 });
console.log(a); // {foo: 0, bar: 1, baz: 2}

let obj = { person: 'Thor' };
let clone = Object.assign({}, obj);
console.log(clone); // {person: "Thor"}

var first = { name: 'Tony' };
var last = { lastName: 'Stark' };
var person = Object.assign(first, last); // change first object 

console.log(person); // {name: 'Tony', lastName: 'Stark'}
console.log(first); //  { name: "Tony", lastName: "Stark" }

/*

Object:     
    -data is stored as key value pairs.
    -   key has to be a number, string, or symbol. 
    -   The value can be anything so also other objects, functions etc.
    -   object is an non ordered data structure, i.e. the sequence of insertion of 
        key value pairs is not remembered

ES6 Map:
    -   data is stored as key value pairs. 
    -   unique key maps to a value.
    -   Both the key and the value can be in any data type.
    -   A map is a iterable data structure, this means that the sequence 
        of insertion is remembered and that we can access the elements in e.g. a for..of loop

Key differences:
    -   Map is ordered and iterable, whereas a objects is not ordered and not iterable
    -   We can put any type of data as a Map key, whereas objects can only have a number, string, or symbol as a key.
    -   Map inherits from Map.prototype. This offers all sorts of utility functions and properties which makes working with Map objects a lot easier.

*/

// Object 
let obj = {};

// adding properties to a object
obj.prop1 = 1;
obj[2] = 2;

// getting nr of properties of the object
console.log(Object.keys(obj).length);

// deleting a property
delete obj[2];

console.log(obj);

// MAP
const myMap = new Map();
const keyString = 'a string', keyObj = {}, keyFunc = function () { };

// setting the values
myMap.set(keyString, "value associated with 'a string'");
myMap.set(keyObj, 'value associated with keyObj');
myMap.set(keyFunc, 'value associated with keyFunc');

console.log(myMap.size); // 3

// getting the values
console.log(myMap.get(keyString));    // "value associated with 'a string'"
console.log(myMap.get(keyObj));       // "value associated with keyObj"
console.log(myMap.get(keyFunc));      // "value associated with keyFunc"

console.log(myMap.get('a string'));   // "value associated with 'a string'"
// because keyString === 'a string'
console.log(myMap.get({}));           // undefined, because keyObj !== {}
console.log(myMap.get(function () { })); // undefined, because keyFunc !== function () {}


/*

    The plain JavaScript Object { key: 'value' } 
    holds structured data. But plain JS object has its limitations :

    -   Only strings and symbols can be used as keys of Objects. 
        If we use any other things say, numbers as keys of an object then during 
        accessing those keys we will see those keys will be converted into strings implicitly
        causing us to lose consistency of types.
        
        const names= {1: 'one', 2: 'two'}; Object.keys(names); // ['1', '2']

    -   There are chances of accidentally overwriting inherited properties from prototypes
        by writing JS identifiers as key names of an object (e.g. toString, constructor etc.)

    -   Another object cannot be used as key of an object, 
        so no extra information can be written for an object 
        by writing that object as key of another object and 
        value of that another object will contain the extra information

    -   Objects are not iterators

    -   The size of an object cannot be determined directly

*/ 