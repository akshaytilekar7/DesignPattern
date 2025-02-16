namespace SRP.Example1.N;

public class OrderValidator
{
    public bool Validate(Order order) { return true; }
}

public class OrderRepository
{
    public void Save(Order order) { /* Database logic */ }
}

// Updated EmailService with new template
public class EmailService
{
    public void SendConfirmation(Order order)
    {
        // Old email logic

        // New email logic with template
        SendEmailWithNewTemplate(order); // <-- Only this class changes
    }

    private void SendEmailWithNewTemplate(Order order) { /* New email logic */ }
}

public class OrderProcessor
{
    private readonly OrderValidator _validator;
    private readonly OrderRepository _repository;
    private readonly EmailService _emailService;

    public OrderProcessor(OrderValidator validator, OrderRepository repository, EmailService emailService)
    {
        _validator = validator;
        _repository = repository;
        _emailService = emailService;
    }

    public void ProcessOrder(Order order)
    {
        if (_validator.Validate(order))
        {
            _repository.Save(order);
            _emailService.SendConfirmation(order);
        }
    }
}