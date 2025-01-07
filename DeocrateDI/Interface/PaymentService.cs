namespace DeocrateDI.Interface;

public class PaymentService : IPaymentService
{
    private readonly AppDbContext dbContext;
    public PaymentService(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public int GetById(int id)
    {
        Console.WriteLine($"actual service");

        return id;
    }
}
