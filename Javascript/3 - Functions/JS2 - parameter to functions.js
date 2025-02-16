// Parameters and Arguments


// 1 Default Parameters
    function greet(name = "Guest") {
        return `Hello, ${name}`;
    }

// 2 Rest Parameters : Collect multiple arguments into an array

    function sum(...numbers) {
        return numbers.reduce((acc, num) => acc + num, 0);
    }   

// 3 Spread Syntax : Spread array elements as arguments

    const nums = [1, 2, 3];
    Math.max(...nums); // 3

// this Keyword
//  -   this depends on how the function is called.

function showThis() {
    console.log(this);
}

// this in Arrow Functions
//  this is inherited from the parent scope.

const obj = {
    value: 42,
    arrowFunc: () => console.log(this), // Inherits `this` from parent
};


