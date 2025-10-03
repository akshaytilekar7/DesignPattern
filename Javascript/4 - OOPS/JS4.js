//

/*
    STATIC property
    -   we add static proeprty directly to constructor funtion
    -   we access them from directly from constructor funtion
    -   cannot access from instance object
    -   

*/



/*
    STATIC Method
    -   we add static property directly to constructor funtion
    -   we access them from directly from constructor funtion
    -   we cant use 'this' keyword inside static function so pass them as parameter
    -   cannot access from instance object

*/


// new way
class Account {
    static MIN_BALANCE = 1000;
    static isValidOpeningBalance(amount) {
        return amount >= Account.MIN_BALANCE;
    }
}


// old way
function Person(firstName, lastName, age) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
}

Person.adultAge = 18; // static property
Person.isAdultStatic = function (age) { return age > Person.adultAge }; // static function


let akshay = new Person('Akshay', 'Tilekar', 30);
console.log(akshay.isAdult()); // true

let course = { requiredAge: Person.adultAge };

