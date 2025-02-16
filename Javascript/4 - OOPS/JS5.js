// private method and property in constructor functions
// inshort dont use this use let then it will be provate but has limitation
// if we use let then closure comes in icture

function Person(firstName, lastName, age) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
}

function Student(firstName, lastName, age) {
    Person.call(this, firstName, lastName, age);   // IMP
    this.courses = [];
}
Student.prototype = Object.create(Person.prototype);  // IMP if not use create same memory 
Student.prototype.constructor = Student;
Student.prototype.enroll = function (course) {
    this.courses.push(course);
};
Student.prototype.isAdult = function () {
    return this.age >= 21;
};

let jimPerson = new Person('Jim', 'Cooper', 18);
let jimStudent = new Student('Jim', 'Cooper', 18);
//display(jimPerson.isAdult());
display(jimStudent.isAdult());
