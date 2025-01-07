namespace LSPExample;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

public class CreditCardPayment : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"ProcessPayment : {nameof(CreditCardPayment)}");
    }
}

public class PayPalPayment : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"ProcessPayment : {nameof(PayPalPayment)}");
    }
}

public class BankTransferPayment : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"ProcessPayment : {nameof(BankTransferPayment)}");
    }

    public void ValidateBankDetails()
    {
        Console.WriteLine($"ValidateBankDetails : {nameof(BankTransferPayment)}");
    }
}

// Violating LSP:
public class Service
{
    private readonly IPaymentProcessor paymentProcessor;

    public Service(IPaymentProcessor paymentProcessor)
    {
        this.paymentProcessor = paymentProcessor;
    }
    public void Process(decimal amount)
    {
        paymentProcessor.ProcessPayment(amount);

        // Violating LSP: BankTransferPayment has extra method, but this can't be safely called on IPaymentProcessor
        var bankTransfer = paymentProcessor as BankTransferPayment;
        if (bankTransfer != null)
            bankTransfer.ValidateBankDetails();
    }
}
