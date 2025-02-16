// Advance

// sort()
// Sorts the elements of an array in place and returns the sorted array
// Note: By default, it converts elements to strings and sorts them lexicographically.
const arr = [3, 1, 2];
arr.sort(); // [1, 2, 3]

// reverse(): Reverses the array in place and returns the reversed array.
const arr = [1, 2, 3];
arr.reverse(); // [3, 2, 1]

// includes(): Checks if a specified element is present in the array.
const arr = [1, 2, 3];
const result = arr.includes(2); // true

// indexOf(): Returns the index of the first occurrence of a specified element, or -1 if not found.
const arr = [1, 2, 3];
const index = arr.indexOf(2); // 1

// join(): Joins all elements of the array into a string, separated by a specified separator
const arr = [1, 2, 3];
const str = arr.join('-'); // "1-2-3"

// flat(): Flattens nested arrays into a single array up to the specified depth
const arr = [1, [2, [3, 4]]];
const flatArr = arr.flat(2); // [1, 2, 3, 4]

// flatMap(): First maps each element using a mapping function, 
// then flattens the result into a new array.
const arr = [1, 2, 3];
const mappedArr = arr.flatMap(x => [x, x * 2]); // [1, 2, 2, 4, 3, 6]

// from(): Creates a new array from an iterable or array-like object.
const str = '123';
const arr = Array.from(str); // ['1', '2', '3']

// findLast(): Returns the last element in the array that satisfies the provided testing function
const arr = [1, 2, 3];
const result = arr.findLast(x => x < 3); // 2

// sort() with Custom Comparator: Custom sorting order can be achieved with a comparison function.
const arr = [10, 2, 30, 5];
arr.sort((a, b) => a - b); // [2, 5, 10, 30] (ascending order)



