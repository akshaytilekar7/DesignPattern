// Methid overriding


// new JS is the same as C# for overidding and polymorphism as we have class extends keyword
/*

📌 Summary
✔ Method Overriding (Old JS)
    Use prototype inheritance (Object.create).
    Override methods in child constructors.
✔ Polymorphism (Old JS)
    Use a common function (printOrderTotal) to handle multiple objects.
    Child objects override methods, but we call them using the same function.

*/
class PaymentGateway {
    processPayment(amount) {
        console.log(`Processing payment of $${amount}`);
    }
}

class CreditCardPayment extends PaymentGateway {
    processPayment(amount) {
        console.log(`Processing Credit Card payment of $${amount} with 2% fee`);
    }
}

class PayPalPayment extends PaymentGateway {
    processPayment(amount) {
        console.log(`Processing PayPal payment of $${amount} with 1.5% fee`);
    }
}

// Usage
const payment1 = new CreditCardPayment();
payment1.processPayment(100);
// Output: Processing Credit Card payment of $100 with 2% fee

const payment2 = new PayPalPayment();
payment2.processPayment(100);
// Output: Processing PayPal payment of $100 with 1.5% fee


