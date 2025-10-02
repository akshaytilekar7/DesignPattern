using ThirdPartyService;

namespace MyApp;

public class DecoratorClient : IEmployeeService
{
    private readonly IEmployeeService employeeService;

    public DecoratorClient(IEmployeeService employeeService)
    {
        this.employeeService = employeeService;
    }

    public void CalculateTotalCost(int seconds)
    {
        Console.WriteLine("Start");
        employeeService.CalculateTotalCost(seconds);
        Console.WriteLine("End");

    }
}
