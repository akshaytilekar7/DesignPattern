/*

 All objects are like to a have prototype and
 prototype is previosuly defined blueprint

many objects are predefined for u
objects are link to prototype which defined their behaviour


Prototype chanining

myDate =   |  Date   |    -> Date.prototype     -> Object.prototype
           |         |       - getday()             - toString()
           | (empty) |       - getHours()
           |         |       - getSeconds()
           |         |

when we call getDay() on myDate then JS looks for getDay() in 
    Date then Date.prototype and then Object.prototype


*/

const course = {
    title: "array and objects",
    id: 1
}

const myDate = new Date();
myDate.getDay();

// myDate is Date object as its link to date.prototype
// and course is "O"bjects object as its link to Object.prototype
