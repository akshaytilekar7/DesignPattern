using DeocrateDI.Interface;
namespace DeocrateDI.Decorator;
public class CachingPaymentService : IPaymentService
{
    private readonly IPaymentService paymentService;

    public CachingPaymentService(IPaymentService paymentService)
    {
        this.paymentService = paymentService;
    }
    public int GetById(int id)
    {
        Console.WriteLine($"decorator start");

        var value = paymentService.GetById(id);

        Console.WriteLine("decorator end");

        return value;
    }
}
