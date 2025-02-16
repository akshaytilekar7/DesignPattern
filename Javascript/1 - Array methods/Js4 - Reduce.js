// reduce():
// powerful tool for transforming an array into a single value

array.reduce((accumulator, currentValue, currentIndex, array) => {
    // logic here
}, initialValue);

// accumulator : The accumulated result.
//               accumulator is a value that is carried over between each iteration of the array.
//               It acts as a "running total" or a "container" for the result that is being calculated or transformed.

// currentValue: The current array element being processed

// currentIndex: (Optional) The index of the current element.

// array: (Optional) The array reduce is called on

// initialValue: (Optional) The initial value for the accumulator.
//      // NOTE : If don't pass an initial value to then use first element of array


// Example 1 Aggregating Data: Total Sales
// - Array of objects representing sales and you need to calculate the total sales.
const sales = [
    { product: "Laptop", price: 1000, quantity: 3 },
    { product: "Phone", price: 500, quantity: 5 },
    { product: "Tablet", price: 300, quantity: 2 },
];

const totalSales = sales.reduce((total, item) => {
    return total + (item.price * item.quantity);
}, 0);

console.log(totalSales); // Output: 4500

// Example 2 - Grouping Data by Key
// Suppose you want to group products by category

const products = [
    { name: "Laptop", category: "Electronics" },
    { name: "Shirt", category: "Clothing" },
    { name: "Phone", category: "Electronics" },
    { name: "Pants", category: "Clothing" },
];

const groupedProducts = products.reduce((group, product) => {
    const category = product.category;
    if (!group[category]) {
        group[category] = [];
    }
    group[category].push(product.name);
    return group;
}, {});

console.log(groupedProducts);
/*
Output:
{
    Electronics: ["Laptop", "Phone"],
    Clothing: ["Shirt", "Pants"]
}
*/


// Example 3 - Removing Duplicates

const numbers = [1, 2, 3, 4, 3, 2, 1, 5];

const uniqueNumbers = numbers.reduce((unique, num) => {
    if (!unique.includes(num)) {
        unique.push(num);
    }
    return unique;
}, []);

console.log(uniqueNumbers); // Output: [1, 2, 3, 4, 5]


// Example 4 - Building a Lookup Table


const users = [
    { id: 1, name: "Alice" },
    { id: 2, name: "Bob" },
    { id: 3, name: "Charlie" },
];

const userLookup = users.reduce((lookup, user) => {
    lookup[user.id] = user.name;
    return lookup;
}, {});

console.log(userLookup);
/*
Output:
{
    1: "Alice",
    2: "Bob",
    3: "Charlie"
}
*/

// Example 5 - Flattening Nested Arrays

const nestedArray = [[1, 2], [3, 4], [5, 6]];

const flatArray = nestedArray.reduce((flat, current) => {
    return flat.concat(current);
}, []);

console.log(flatArray); // Output: [1, 2, 3, 4, 5, 6]

// not a good choice use this instead
const arr = [1, [2, [3, 4]]];
const flatArr = arr.flat(2); // [1, 2, 3, 4]


// reduceRight(): Same as reduce(), but applies the function from right to left.
const arr = [1, 2, 3];
const sum = arr.reduceRight((acc, x) => acc + x, 0); // 6

// NOTE : don't pass an initial value to then use first element of array
const products = [
    { name: "Laptop", category: "Electronics" },
    { name: "Shirt", category: "Clothing" },
    { name: "Phone", category: "Electronics" },
    { name: "Pants", category: "Clothing" },
];


const arr = products.reduce((result, item) => {
    if (!result[item.category]) {
        result[item.category] = [];
    }
    result[item.category].push(item.name);
    return result; // Return the updated accumulator
}, {});

console.log(result);


// Example of group by

const people = [
    { name: 'Alice', age: 25 },
    { name: 'Bob', age: 30 },
    { name: 'Charlie', age: 25 },
    { name: 'David', age: 30 },
    { name: 'Eve', age: 35 }
];

const groupedByAge = people.reduce((result, person) => {
    const age = person.age; // Group by 'age'
    if (!result[age]) {
        result[age] = []; // If the age doesn't exist in the result object, create an empty array
    }
    result[age].push(person); // Add the person to the group based on their age
    return result;
}, {});

console.log(groupedByAge);
