using ThirdPartyService;

namespace MyApp;

public static class EmployeeServiceExtensions
{
    public static IEmployeeService WithLogging(this IEmployeeService service)
    {
        return new DecoratorClient(service);
    }
}
