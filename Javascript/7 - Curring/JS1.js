/*

Currying in JavaScript – Business Logic Use Case
    -   Currying is a functional programming technique where a 
        function takes multiple arguments one at a time instead of all at once.
    -   👉 It transforms a function f(a, b, c) into f(a)(b)(c).

    Why Use Currying in Business Logic?
        ✅ Reusability – Tax rates don’t change often, so we set them once.
        ✅ Customization – We can predefine tax rates and discounts for different user types.
        ✅ Modularity – Each function does one job, making it easier to test.

    Conclusion
        🔹 Without currying: We pass all parameters together → Less modular.
        🔹 With currying: We pre-set values and pass parameters step by step → More reusable & flexible.
        👉 Practical Benefit: You can define different tax rules once and reuse them for multiple transactions!


Partial Application
    -   Pre-fixes some arguments, returns a function for the rest.
    -   Can take multiple remaining arguments.
    
    Both Currying and Partial Application return new functions with some arguments pre-fixed.
    The difference is that currying always enforces a one-argument-per-call rule, 
    while partial application is more flexible, allowing multiple arguments in a single call.


*/


