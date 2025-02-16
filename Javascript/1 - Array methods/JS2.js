// Intermidiate

// forEach(): Executes a provided function once for each array element
const arr = [1, 2, 3];
arr.forEach(item => console.log(item)); // logs 1, 2, 3

// map(): Creates a new array with the results of applying a function to every element
const arr = [1, 2, 3];
const newArr = arr.map(x => x * 2); // [2, 4, 6]

// filter():
// - Creates a NEW ARRAY WITH ALL ELEMENTS that pass the test implemented by the provided function.
// - Finds all elements in the array that satisfy the condition and return new array
const arr = [1, 2, 3, 4];
const newArr = arr.filter(x => x > 2); // [3, 4]

// find(): Returns the first element that satisfies the provided testing function
// - Finds only the first element in the array that satisfies the condition & return single value
const arr = [1, 2, 3];
const result = arr.find(x => x > 1); // 2

// findIndex(): Returns the index of  the first element that satisfies the provided testing function.
const arr = [1, 2, 3];
const index = arr.findIndex(x => x > 1); // 1

// some(): Tests whether at least one element in the array passes the provided test function.
const arr = [1, 2, 3];
const result = arr.some(x => x > 2); // true

// every(): Tests whether all elements in the array pass the provided test function
const arr = [1, 2, 3];
const result = arr.every(x => x > 0); // true


