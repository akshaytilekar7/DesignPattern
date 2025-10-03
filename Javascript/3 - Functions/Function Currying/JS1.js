/*

Currying 
    -   is a technique where a function is transformed to 
        take arguments one at a time instead of all at once.
    -   Transforming a function f(a, b, c) into a sequence like f(a)(b)(c).
    -   Returns new functions until all args are provided.
    -   A curried function does not execute until all required arguments are provided.
    -   Each call returns a new function until all parameters are received.
    -   This improves code reusability, composition, and partial application.
*/

function multiply(a) {
    return function (b) {
        return function (c) {
            return a * b * c;
        };
    };
}

console.log(multiply(2)(3)(4)); // Output: 24
