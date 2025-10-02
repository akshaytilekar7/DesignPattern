namespace CoreWebApi.Constraint;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

public class CustomActionFilter : IActionFilter
{
    private readonly ILogger<CustomActionFilter> _logger;
    private readonly string _customMessage;

    public CustomActionFilter(ILogger<CustomActionFilter> logger, string customMessage)
    {
        _logger = logger;
        _customMessage = customMessage;
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        _logger.LogInformation("Executing action with message: {Message}", _customMessage);
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        _logger.LogInformation("Action executed with message: {Message}", _customMessage);
    }
}