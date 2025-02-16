// Using JavaScript Classes
/*
new keyword
    1. Creates a new object
    2. Binds this to the new object
    3. Adds the properties to this
    4. Calls the Class' constructor
    5. Implicitly returns the new object

    -   private property
    -   static method and data member
    -   object cant access statid data and method 
    -   no this in static method

*/

class Person {
    static adultAge = 18;
    firstName;
    lastName;
    age;
    #adultAge = 18;  // private property

    constructor(firstName, lastName, age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }
    #isAdult() { // private method
        return this.age >= this.#adultAge || this.age >= Person.adultAge ;
    }
    isQualified() {
        return this.#isAdult();
    }
    get fullName() {
        return this.firstName + this.lastName;
    }
    set fullName(fullName) {
        this.firstName = fullName.split(' ')[0];
        this.lastName = fullName.split(' ')[1];
    }
    static isAdult(age) {  // static method, name can same as class method
        return this.age > age;
    }
}

let jim = new Person('Jim', 'Cooper', 17);
console.log(jim.fullName); // no bracket  JimCooper
jim.fullName = 'Akshay Tilekar'
console.log(jim.fullName); // no bracket AkshayTilekar
console.log(Person.adultAge); // 18
console.log(jim.adultAge); // undefined

console.log(isAdult(jim.age)); // 18
console.log(jim.isAdult(18)); // not define
console.log(jim.#adultAge); // errro cant access


