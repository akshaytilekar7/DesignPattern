// Arrow
// You don’t rebind the value of this when you use an arrow function inside
// of another function:

var funcName = (params) => {
    return params + 2;
}

console.log(funcName(2));  //4

// Ex
const outerThis = this;

const func = () => {
    console.log(this === outerThis);
};

func.call(null);        //true
func.apply(undefined);  //true
func.bind({})();       //true 

// this will ALWAYS REFER TO THE LEXICAL SCOPE
// not impact by any rule from the 4 rules 

//new func();
// new before arrow function will give an error.because arrow functions can’t run with new.

var group = {
    title: "Our Group",
    students: ["John", "Pete", "Alice"],

    showList1() {
        this.students.forEach((student) => {
            // this here refer to group object
            console.log(this.title + ': ' + student);
        }
        );
    },
    showList2() {
        this.students.forEach(function (student) {
            console.log(this.title + ': ' + student);
        });
    }
};

group.showList1(); //   forEach, the arrow function is used, so this.title in it is exactly the same as in the outer method showList. That is: group.title.
group.showList2();

//Our Group: John
//Our Group: Pete
//Our Group: Alice

//undefined: John
//undefined: Pete
//undefined: Alice

 // Key notes

//  1     :   The value of this is usually determined by a functions execution context.
//  2     :   In the global scope, this refers to the global object(the window object).
//  3     :   The object that is standing before the dot is what the this keyword will be bound to.
//  4     :   We can set the value of this explicitly with call(), bind(), and apply()
//  5     :   When the new keyword is used(a constructor), this is bound to the new object being created.
//  6     :   Arrow Functions don’t bind this - instead, this is bound lexically(i.e.based on the original context)