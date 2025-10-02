using DeocrateDI.Decorator;
using DeocrateDI.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DeocrateDI;

internal class Program
{
    static async Task Main(string[] args)
    {
        var services = new ServiceCollection();

        services.AddDbContext<AppDbContext>(options =>
            options.UseInMemoryDatabase("MemberDb"));


        // traditional way not useful

        services.AddScoped<IPaymentService, PaymentService>();
        services.AddScoped<IPaymentService>(provider =>
        {
            var dbConext = provider.GetRequiredService<AppDbContext>();
            return new CachingPaymentService(new PaymentService(dbConext));
        });

        // BEST WAY
        services.AddScoped<IPaymentService, PaymentService>();
        services.Decorate<IPaymentService, CachingPaymentService>(); // Apply decorator

        var serviceProvider = services.BuildServiceProvider();

        var paymentService = serviceProvider.GetRequiredService<IPaymentService>();

        var x = paymentService.GetById(100);
        Console.WriteLine($"Result from GetById: {x}"); 
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

