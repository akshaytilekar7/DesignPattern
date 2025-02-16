using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.PaymentBefore;

// High-level module (business logic)
public class PaymentService
{
    private readonly PayPalPaymentProcessor _paymentProcessor;

    public PaymentService()
    {
        _paymentProcessor = new PayPalPaymentProcessor(); // Direct dependency on low-level module
    }

    public void ProcessPayment(decimal amount)
    {
        _paymentProcessor.Process(amount);
    }
}

// Low-level module (implementation detail)
public class PayPalPaymentProcessor
{
    public void Process(decimal amount)
    {
        // Process payment via PayPal
    }
}

// PaymentService (high-level) directly depends on PayPalPaymentProcessor (low-level).
// If you want to switch to a different payment processor (e.g., Stripe),
//  you must modify PaymentService, violating the Open/Closed Principle.
