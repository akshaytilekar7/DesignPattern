namespace SRP.Example1.After;

public class OrderValidator
{
    public bool Validate(Order order) { return true; }
}

public class OrderRepository
{
    public void Save(Order order) { /* Database logic */ }
}

public class EmailService
{
    public void SendConfirmation(Order order) { /* Email logic */ }
}

// Orchestrator: Coordinates the process
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