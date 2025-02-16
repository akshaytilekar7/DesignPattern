// A decorator is just a Higher - Order Function that wraps another function or class.
// It adds extra functionality(like logging, caching, validation) before / after the main function executes.
// Used in frameworks like NestJS, TypeScript, Angular, Express.js Middleware, etc.

function logExecution(targetFunction) {
    return function (...args) {
        console.log(`Executing ${targetFunction.name} with arguments:`, args);
        const result = targetFunction(...args);
        console.log(`Result:`, result);
        return result;
    };
}

function add(a, b) {
    return a + b;
}

const loggedAdd = logExecution(add);

loggedAdd(5, 3); 
