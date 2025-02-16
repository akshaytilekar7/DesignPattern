/*

Iterators (Manual Control)
    -   An iterator is an object that follows the Iterator Protocol:
        -   It has a next() method that returns { value, done }.
        -   Used to iterate over custom sequences.

Generators (Auto-Controlled Iterators)
    -   A generator is a special function that can pause and resume execution using yield.
        -   Uses function* syntax.
        -   Automatically implements the iterator protocol. 
        -   Saves state between calls.
    -   Use function*, auto-pause with yield.
    -   Generators are useful when we need lazy evaluation, controlled iteration, 
        and on-demand execution. Here are some practical use cases:

    -   TL;DR – When to Use Generators?
        ✅ Handling large datasets efficiently (Lazy Loading)
        ✅ Breaking down async tasks into steps
        ✅ Generating infinite sequences (IDs, timestamps, numbers)
        ✅ Interactive systems (CLI tools, games)
        ✅ Avoiding UI freezing in long-running computations
        ✅ Making objects iterable easily
*/

function* numberGenerator() {
    let num = 1;
    while (true) {
        yield num++; // Pause execution and return `num`
    }
}

const gen = numberGenerator();
console.log(gen.next().value); // 1
console.log(gen.next().value); // 2
console.log(gen.next().value); // 3


// Example 2

function* fetchOrders(apiUrl, pageSize) {
    let page = 1;

    while (true) {
        const response = fetch(`${apiUrl}?page=${page}&limit=${pageSize}`)
            .then(res => res.json());

        const orders = yield response;  // Pause until `next().value` is resolved

        if (orders.length === 0) return; // Stop when no more data

        page++;
    }
}

// 🔹 Usage: Fetch orders lazily on demand
const ordersGenerator = fetchOrders("https://api.example.com/orders", 100);

async function processOrders() {
    let nextBatch = await ordersGenerator.next().value;  // Fetch first batch

    while (nextBatch) {
        console.log("Processing:", nextBatch);
        nextBatch = await ordersGenerator.next(nextBatch).value;  // Fetch next batch
    }
}
processOrders();
