/*

Real Business Use Case – Tax Calculation in an E - Commerce App
Let’s say you need a function to calculate the final price of a product based on:

    Tax Rate(depends on country)
    Discount(depends on user type)
    Base Price(product price)

*/


// Without Currying (Regular Function)
function calculateFinalPrice(taxRate, discount, basePrice) {
    return basePrice + basePrice * taxRate - discount;
}

// Usage
console.log(calculateFinalPrice(0.1, 20, 100)); // 90


// With Currying – Reusability & Modularity

function calculateFinalPrice(taxRate) {
    return function (discount) {
        return function (basePrice) {
            return basePrice + basePrice * taxRate - discount;
        };
    };
}

// Usage
const applyTaxForUS = calculateFinalPrice(0.1);   // 10% tax
const applyDiscountForPremiumUser = applyTaxForUS(20); // $20 discount

console.log(applyDiscountForPremiumUser(100)); // 90
console.log(applyDiscountForPremiumUser(200)); // 180

// Alternate
const calculateFinalPrice = (taxRate) => (discount) => (basePrice) =>
    basePrice + basePrice * taxRate - discount;

const applyTaxForUS = calculateFinalPrice(0.1);
const applyDiscountForPremiumUser = applyTaxForUS(20);

console.log(applyDiscountForPremiumUser(100)); // 90
console.log(applyDiscountForPremiumUser(200)); // 180

