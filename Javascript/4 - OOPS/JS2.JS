
// Constructor function -> this and new

function Person(firstName, lastName, age) {
    this.firstName = firstName;
    this.lastNmae = lastName;
    this.age = age;
    this.fullName = function () { this.firstName + this.lastName }
}

let akshay = new Person('Akshay', 'Tilekar', 30);
console.log(akshay.hasOwnProperty('age')); // True , in case of proto object this will be false see JS1.js

/*
new keyword
    -   create brand new object
    -   bind 'this' to new object
    -   calls the functon ie, next word after new like -> new Perosn('A','B')
    -   implicitly return a new object


One issue if we create multiple oject like akshay and yash 
using Person each object have separate copy of function fullName which is BAD
so add this function to object prototype


*/

// BEST PRACTICES

function Person(firstName, lastName, age) {
    this.firstName = firstName;
    this.lastNmae = lastName;
    this.age = age;
}

Person.prototype.fullName = function () { this.firstName + this.lastName }

let akshay = new Person('Akshay', 'Tilekar', 30);

// now only 1 copy of fun but
console.log(akshay.hasOwnProperty('fullName')); // false
console.log(akshay.__proto__.hasOwnProperty('fullName'));  // true





