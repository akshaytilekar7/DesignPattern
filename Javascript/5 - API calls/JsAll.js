// prmoise example

loginUser("pooja", "password123")
    .then(user => getCart(user.id))
    .then(cart => applyDiscount(cart))
    .then(discountedCart => processPayment(discountedCart))
    .then(paymentConfirmation => sendInvoice(paymentConfirmation))
    .then(invoice => console.log("Invoice sent!", invoice))
    .catch(err => console.error("Error:", err)); 


// async await
async function checkout() {
    try {
        let user = await loginUser("pooja", "password123");
        let cart = await getCart(user.id);
        let discountedCart = await applyDiscount(cart);
        let paymentConfirmation = await processPayment(discountedCart);
        let invoice = await sendInvoice(paymentConfirmation);
        console.log("Invoice sent!", invoice);
    } catch (err) {
        console.error("Error:", err);
    }
}
checkout();
