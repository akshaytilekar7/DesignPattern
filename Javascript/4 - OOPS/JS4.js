//  

/*
    STATIC property
    -   we add static proeprty directly to constructor funtion
    -   we access them from directly from constructor funtion
    -   cannot access from instance object
    -   

*/


function Person(firstName, lastName, age) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
}

Person.adultAge = 18; // static property
Person.isAdultStatic = function (age) { return age > Person.adultAge }; // static function
Person.prototype.isAdult = function () { return Person.isAdultStatic(this.age) };

let akshay = new Person('Akshay', 'Tilekar', 30);
console.log(akshay.isAdult()); // true

let course = { requiredAge: Person.adultAge };

console.log(akshay.adultAge); // undefined   IMP 
console.log(Person.adultAge); // 18  IMP

console.log(akshay.isAdult()); // YES
console.log(Person.isAdultStatic(akshay.age)); // YES


/*
    STATIC Method
    -   we add static proeprty directly to constructor funtion
    -   we access them from directly from constructor funtion
    -   we cant use 'this' keyword inside static function so pass them as parameter
    -   cannot access from instance object

*/