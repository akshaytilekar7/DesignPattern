// getter and setter ion ctor function

function Person(firstName, lastName, age) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
}

Person.prototype.IsAdult1 = function () { return true; } // not working dont know why
Person.prototype = {
    get fullName() { return this.firstName + " " + this.lastName + " get"; },
    set fullName(fnln) {
        this.firstName = fnln.split(' ')[0];
        this.lastName = fnln.split(' ')[1];
    },
    IsAdult2() { return true }

};
Person.prototype.IsAdult3 = function () { return true; }

let akshay = new Person('Akshay', 'Tilekar', 30);
console.log(akshay.getName)
console.log(akshay.fullName);
// console.log(akshay.IsAdult1()); // not working dont know why
console.log(akshay.IsAdult2());
console.log(akshay.IsAdult3());


