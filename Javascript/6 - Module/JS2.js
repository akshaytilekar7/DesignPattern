// ECMA Script

/*

ECMAScript Module 
    -   Introduced in 2015
    -   Lifetimes in ES Modules
        - Each module is loaded once
        - You're in control of lifetime
        - How can it be both?
    -   Exports can be simple objects, or compose complex objects
    -   Imports end up being all const, but you can work around that


*/

import path from "path"; // Import built-in or package module

import user from "./user.js"; // Import from.js file

import name from "./utils/name.js"; // Import with path to file
// Shortcut to ./utils/index.js

import utils from "./utils";
// Import from Directory(e.g.index.js) 
// Not supported by default in Node

import * as ModuleName from "./user.js"; // Import namespace (all exports)
import user from "./user.js"; // Imports default export
import { showUser } from "./user.js"; // Import named export
import user, { showUser } from "./user.js"; // Import default and named

// Export a default object
export default {
    name: "Shawn"
};


// Export named object
export const user = {
    name : "Shawn"
}

// Can separate declaration and export
let user = { name: "Shawn" };
export { user };

//Can separate default too
let user = { name: "Shawn" };
export { user as default };

//Multiple exports at once
export { user as default, showUser };

// Exporting Values
export default "Shawn";
export let birthdate = new Date();
export const theName = "Shawn";

// Exporting Objects
export const user = {
    name: "Shawn"
};

// Exporting Arrays
export let users = [
    { name: "Shawn" }
];

// Exporting Classes
export class User {
    user = "Shawn"
};

// Exporting Functions
export function formatUser(user) {
    // ...
}

// Export something you’ve imported
import { name } from "./name.js";
export let theName = name;

// To Aggregate
export { name } from "./name.js";

// To Aggregate All
export * from "./name.js";


// Exported object
// user.js
export default {
    name: "Hello"
};


//Importing makes it const
// Even if you exported a let
// index.js
import x from "./user.js";
console.log(x.name); // Hello

// Object can be changed
x.name = "Goodbye";
console.log(x.name); // Goodbye

// Re-import and the change persists
import y from "./user.js";
console.log(y.name); // Goodbye


//  Can use factory pattern
// function is const, not the result
// user.js
export default function () {
    return {
        name: "Hello"
    };
}

// Or, classes
// user.js
export class User {
    name = "Hello";
}

