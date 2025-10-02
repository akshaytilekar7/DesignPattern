namespace DIP.PaymentAfter;

// Abstraction (interface)
public interface IPaymentProcessor
{
    void Process(decimal amount);
}

// High-level module (business logic)
public class PaymentService
{
    private readonly IPaymentProcessor _paymentProcessor;

    public PaymentService(IPaymentProcessor paymentProcessor)
    { // Dependency injected
        _paymentProcessor = paymentProcessor;
    }

    public void ProcessPayment(decimal amount)
    {
        _paymentProcessor.Process(amount);
    }
}

// Low-level module (implementation detail)
public class PayPalPaymentProcessor : IPaymentProcessor
{
    public void Process(decimal amount)
    {
        // Process payment via PayPal
    }
}

public class StripePaymentProcessor : IPaymentProcessor
{
    public void Process(decimal amount)
    {
        // Process payment via Stripe
    }
}

// PaymentService now depends on the abstraction (IPaymentProcessor) rather than a concrete implementation.
// You can easily swap payment processors (e.g., PayPal, Stripe) without modifying PaymentService.
// DIP ensures high-level modules depend on abstractions, not concrete implementations.