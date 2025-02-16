/*

Memory Allocation in JavaScript
    Memory is allocated for:
        Variables & Objects: let obj = { name: "Pooja" };
        Functions & Closures: function foo() { let a = 10; }
        DOM Elements & Event Handlers: document.getElementById("btn").addEventListener(...)

    How?
        Mark-and-Sweep Algorithm (Modern GC in V8)
            Mark Phase – GC marks all accessible objects starting from the root (global scope, stack, heap).
            Sweep Phase – Unmarked (inaccessible) objects are collected
        


*/
function unusedObjects() {
    let temp = { data: "I will be garbage collected" };
}
unusedObjects();
// 'temp' goes out of scope, no references → GC removes it.
