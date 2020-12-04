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

