console.log("start!");


// Sum of Numbers
const numbers = [1, 2, 3, 4, 5];

let sum = numbers.reduce((current, val) => {
    return current + val
}, 0);

console.log("sum is : " + sum); // sum is : 15

// 2
const users = [
    { name: "Alice", role: "admin" },
    { name: "Bob", role: "user" },
    { name: "Charlie", role: "admin" },
    { name: "David", role: "user" },
];

//Use reduce to group users by role into an object like:
//
// {
//  admin: [{name: "Alice", ...}, {name: "Charlie", ...}],
//  user: [{name: "Bob", ...}, {name: "David", ...}]
//}

let roles = users.reduce((current, val) => {
    if (current[val.role]) {
        current[val.role].push(val.name);
    } else {
        current[val.role] = [val.name];
    }
    return current; // ✅ return accumulator
}, {});


console.log("roles : ", roles);
// roles :  { admin: [ 'Alice', 'Charlie' ], user: [ 'Bob', 'David' ] }

// 3
const arr = [1, 2, 2, 3, 4, 4, 5];

let uniques = arr.reduce((current, val) => {
    if (!current.includes(val)) {
        current.push(val);
    }
    return current;
}, []);


console.log("uniques : ", uniques);
// uniques: [1, 2, 3, 4, 5]

console.log("end!");

