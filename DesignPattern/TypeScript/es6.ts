/*IN ES5*/
var name1 = 'Hello World';
var message1 = 'Hey' + name1 + ',';

/*IN ES6*/
let name2 = 'Hello World';
let message2 = `Hey ${name2},`;

// let and const
//  -   scoped to the containing “block” not “function”:

// ES5
function onSubmit() {
    // Keep a reference to "this" so 
    //we can use it in the inner function below.
    var that = this;
    orderService({ data: 5 }, function (result) {
        // In JavaScript, ever function defines 
        // its own "this" value.So, "this" in this
        // inner function here is different from "this"
        // in the onSubmit() function.That's why we had to keep a 
        // reference to "this" and store it in "that".Now,
        // we can   use "that":
        that.result = result;
    });
}
function onSubmit2() {
    orderService.store({ data: 5 }, result => {
        // Since we're using an arrow function here,
        // "this" references the "this" value of the
        // containing function (onSubmit).Arrow functions
        // don't re-define "this". 
        this.result = result;
    });
}

//  Destructuring

//  extract properties from an object, or items from an array

const address = {
    street: 'Pallimon',
    city: 'Kollam',
    state: 'Kerala'
};

//ES5
var street1 = address.street;
var city1 = address.city;
var state1 = address.state;
//ES6
const { street, city, state } = address;

// for array 
//ES5
var values1 = ['Hello', 'World'];
var first1 = values1[0];
var last1 = values1[1];
//ES6
const values = ['Hello', 'World'];
const [first, last] = values;


//Import and Export
// MyClass.js
class MyClass {
    constructor() { }
}
export default MyClass;

// Main.js
import MyClass from 'MyClass';

// Promise
// classes
// Rest spread 
