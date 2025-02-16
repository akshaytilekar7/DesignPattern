// MODULES

/*

MODULES
    -   reusable pieces of code that encapsulate functionality and can be imported or exported.
    -   help organize code, avoid global scope pollution, and enable better maintainability.
    -   Why to use
        -   Encapsulation: Keep related code together.
        -   Reusability: Share code across multiple files.
        -   Maintainability: Separate concerns by splitting functionalities into different files.
        -   Avoid Conflicts: Prevent global namespace pollution
    -   Types of Modules in JavaScript
        -   ES Modules (ECMAScript Modules) ES6 (2015)
            -   Uses import and export keywords.
        -   CommonJS Modules (CJS)
            -   Used in Node.js.
            -   Uses require and module.exports
        -   AMD (Asynchronous Module Definition)
            -   Mainly used in browser-based environments
            -   Uses define and require
        -   UMD (Universal Module Definition)
            -   Compatible with both browser and Node.js environments
            -   Adapts to different module systems
            

    -   Way to modularized a code. following are the patterns
    -   using ES Module (all future platform) (imp and used mostly now on)
        -   import/export
        -   Typescript compile to javascript and ES Modules are the default
            but we can configure others
    -   using CommonJS (mostly server side)
        -   module.exports and require('./utils.js')
    -   using AMD Modules (client side DI, not used as much)
        -   define(['./utlis.js'], function(){
                // do
            });


*/

// ES Modules(ECMAScript Modules) ES6(2015)
export function add(a, b) {
    return a + b;
}

// app.js
import { add } from './math.js';
console.log(add(2, 3)); // Output: 5


// CommonJS Modules (CJS)
// math.js
module.exports = {
    add: (a, b) => a + b,
};

// app.js
const math = require('./math');
console.log(math.add(2, 3)); // Output: 5

// AMD (Asynchronous Module Definition)
define(['dependency'], function (dep) {
    return {
        add: (a, b) => a + b,
    };
});

