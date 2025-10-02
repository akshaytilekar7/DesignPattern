namespace CoreWebApi.Constraint;

using Microsoft.AspNetCore.Mvc.ActionConstraints;

public class FeatureFlagConstraint : Attribute, IActionConstraint
{
    private readonly string _featureName;

    public FeatureFlagConstraint(string featureName)
    {
        _featureName = featureName;
    }

    public int Order => 0;

    public bool Accept(ActionConstraintContext context)
    {
        var featureFlagService = new FeatureFlagService();
        var result =  featureFlagService.IsFeatureEnabled(_featureName);
        return result;
    }
}