namespace ThirdPartyService;


public class EmployeeService : IEmployeeService
{
    public void CalculateTotalCost(int seconds)
    {
        Thread.Sleep(seconds);
    }

}
