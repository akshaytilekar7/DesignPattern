using ThirdPartyService;

namespace MyApp;

internal class BusinessLayer
{
    private readonly IEmployeeService employeeService;

    public BusinessLayer(IEmployeeService employeeService)
    {
        this.employeeService = employeeService;
    }
    public void Start()
    {
        employeeService.CalculateTotalCost(5);

        DecoratorClient decoratorClient = new DecoratorClient(new EmployeeService());
        decoratorClient.CalculateTotalCost(5);

        var client = new DecoratorClient(new EmployeeService().WithLogging());
        client.CalculateTotalCost(5);
    }
}
