// JS basic array methods

// push(): Adds one or more elements to the end of an array and returns the new length.
const arr = [1, 2];
arr.push(3); // [1, 2, 3]
arr.push(4, 5); // [1, 2, 3, 4, 5]

// pop(): Removes the last element from an array and returns it.
const arr = [1, 2, 3];
arr.pop(); // 3, arr becomes [1, 2]

// SHIFT(): REMOVES THE FIRST ELEMENT FROM AN ARRAY AND RETURNS IT.
const arr = [1, 2, 3];
arr.shift(); // 1, arr becomes [2, 3]

// UNSHIFT(): ADDS ONE OR MORE ELEMENTS TO THE BEGINNING OF AN ARRAY AND RETURNS THE NEW LENGTH
const arr = [1, 2];
arr.unshift(0); // [0, 1, 2]

// concat(): Merges two or more arrays and returns a new array
const arr1 = [1, 2];
const arr2 = [3, 4];
const newArr = arr1.concat(arr2); // [1, 2, 3, 4]

// slice(): Returns a shallow copy of a portion of an array, without modifying the original.
const arr = [1, 2, 3, 4];
const newArr = arr.slice(1, 3); // [2, 3]

// splice(): Changes the content of an array by removing, replacing, or adding elements
// syntax: array.splice(start, deleteCount, item1, item2, ..., itemN);
// start: The index at which to start changing the array.
// deleteCount: The number of elements to remove from the array starting from the start index.
// item1, item2, ..., itemN: The items to add to the array at the start index
const arr = [1, 2, 3, 4];
arr.splice(1, 2, 'a', 'b'); // arr becomes [1, 'a', 'b', 4]



