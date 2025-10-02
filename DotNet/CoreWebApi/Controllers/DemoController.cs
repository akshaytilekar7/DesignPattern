using Microsoft.AspNetCore.Mvc;
using CoreWebApi.Constraint;

namespace CoreWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DemoController : ControllerBase
{
    [HttpGet]
    [Route("F1")]
    [FeatureFlagConstraint("F1")]
    public JsonResult GetF1()
    {
        var featureName = "";
        return new JsonResult(new { result = $"GetF1 call {featureName}" });
    }

    [Route("F1")]
    [FeatureFlagConstraint("F2")]
    [HttpGet]
    public JsonResult GetF2()
    {
        var featureName = "";
        return new JsonResult(new { result = $"GetF2 call {featureName}" });
    }

    [HttpGet]
    [Route("F1")]
    [FeatureFlagConstraint("F3")]
    public JsonResult GetF3()
    {
        var featureName = "";
        return new JsonResult(new { result = $"GetF3 call {featureName}" });
    }
}

