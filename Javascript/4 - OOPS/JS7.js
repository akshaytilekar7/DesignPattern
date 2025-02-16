// inhertiance in js classes
class Person {
    constructor(firstName, lastName, age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }
    isAdult() {
        return this.age >= 18;
    }
}

class Student extends Person {  // inheritance
    courses = [];
    enroll(course) {
        this.courses.push(course);
    }
    isAdult() {
        return this.age >= 21;
    }
}

let jimPerson = new Person('Jim', 'Cooper', 18);
let jimStudent = new Student('Jim', 'Cooper', 18); // no ctor still work G+IMP
//display(jimPerson.isAdult())
display(jimStudent.isAdult());


class Student2 extends Person {  // inheritance

    // in this case if we custpm ctor then need to call super to work ow CTE
    constructor(fn, ln, cour) {
        super(fn.ln);
        this.courses = cour;
    }
    courses = [];
    enroll(course) {
        this.courses.push(course);
    }
    isAdult() {
        return this.age >= 21;
    }
}

console.log(typeof jimPerson); // Object IMP not Person
console.log(jimPerson instanceof Student); //true
console.log(jimPerson instanceof Person);  //true


// POLYORPHISM JS LOOSY TYPE

function getFullName(person) { // can access any object like Person and Student
    return person.firstName + " " + person.lastName;
}

let jimPerson1 = new Person('A', 'B', 18);
console.log(getFullName(jimPerson1));

let jimPerson2 = new Student('A', 'B', 18);
console.log(getFullName(jimPerson1));

// OVERRIDING in JS
console.log(jimPerson1.isAdult());  // true
console.log(jimPerson2.isAdult());  // false
// easy override  due to prototype chain

3
// ABSTRACT METHOD
/*
    parent method1() -> throw error
    child method1() -> implment here
    but runtime error
  

WARNING OOPS
    -   

*/ 


