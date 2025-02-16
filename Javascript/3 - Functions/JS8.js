function greet(greeting) {
    console.log(`${greeting}, ${this.name}`);
}


// call – Invokes a function with a specific this value and arguments passed individually.
const user = { name: "Pooja" };
greet.call(user, "Hello"); // Output: Hello, Pooja

// apply – Similar to call, but arguments are passed as an array.
greet.apply(user, ["Hi"]); // Output: Hi, Pooja


// bind – Returns a new function with this permanently bound, without immediate execution.
const boundGreet = greet.bind(user, "Hey");
boundGreet(); // Output: Hey, Pooja


/*
    call and apply execute the function immediately.
    bind returns a new function for later execution.
*/