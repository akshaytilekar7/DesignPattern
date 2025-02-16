
// 1 for...in Loop
// Iterates over enumerable properties of an object (keys).
// Best for iterating over objects

    const obj = { name: "Alice", age: 25 };
    for (let key in obj) {
        console.log(key); // "name", "age"
        console.log(obj[key]); // "Alice", 25
    }

    const arr = [10, 20, 30];
    for (let index in arr) {
        console.log(index); // "0", "1", "2"
        console.log(arr[index]); // 10, 20, 30
    }

//  2 for...of Loop
//  Iterates over iterable objects like arrays, strings, Maps, Sets, etc.
//  Best for looping through values in an array or iterable
//  Doesn’t access object properties, only the values

    const arr = [10, 20, 30];
    for (let value of arr) {
        console.log(value); // 10, 20, 30
    }

    const str = "hello";
    for (let char of str) {
        console.log(char); // "h", "e", "l", "l", "o"
    }

//  2.1 With entries():
//   to get both keys and values, use entries() with for...of:

    const arr = ["a", "b", "c"];
    for (let [index, value] of arr.entries()) {
        console.log(index, value); // 0 "a", 1 "b", 2 "c"
    }


// 3 for Loop
// General-purpose loop for custom iteration
// Best for arrays when precise control over the loop is needed.

    const arr = [10, 20, 30];
    for (let i = 0; i < arr.length; i++) {
        console.log(arr[i]); // 10, 20, 30
    }

// 4 Array.foreach
//  Array.prototype.forEach() has callback support,
//  forEach() accepts a callback function as an argument, and this callback function 
//              is invoked once for each element in the array.
//  The callback can have up to three parameters:

    // Current Element
    // Current Index
    // Array itself

//  forEach() method doesn’t return anything (undefined) so Cannot chain other methods
//  not suitable for breaking or early exits (unlike for or for...of).


    const numbers = [1, 2, 3];
    numbers.forEach((num, index, arr) => {
        console.log(`Value: ${num}, Index: ${index}, Array: ${arr}`);
        // Logs: "Value: 1, Index: 0, Array: 1,2,3" (and so on)
    });

/*

    Objects: Use for...in.
    Arrays (values): Use for...of or forEach().
    Arrays (keys and values): Use for...of with entries().
    Custom Iteration: Use for.

*/




